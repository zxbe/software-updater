using System;
using System.Collections.Generic;
using System.IO;

using Com.QueoMedia.Updater.Data;

using UpdateGenerationWizard2010.Data;
using UpdateGenerationWizard2010.Interfaces;
using UpdateGenerationWizard2010.Views.Wizard.Winform;

using UpdateServerManager2010Services;
using UpdateServerManager2010Services.Implementation;

namespace UpdateGenerationWizard2010.Views.Wizard.Controller.Implementation {
    internal class UpdateGeneratorController : IUpdateGeneratorController {
        private readonly IUpdateGenerator _attachedView;

        private readonly IUpdateGeneratorService _generatorService;

        private VersionNumber _appliesTo;
        private string _destinationFolder;
        private IList<UpdateFile> _files;
        private VersionNumber _resultsIn;

        public UpdateGeneratorController(IUpdateGenerator attachedView){
            _generatorService = new UpdateGeneratorService();

            _attachedView = attachedView;
            _attachedView.DestinationDirChanged += AttachedViewDestinationDirChanged;
            _attachedView.ItemAddedToFiles += AttachedViewItemAddedToFiles;
            _attachedView.Page1Activated += _attachedView_Page1Activated;
            _attachedView.Page2Activated += AttachedViewPage2Activated;
            _attachedView.Page3Activated += _attachedView_Page3Activated;
            _attachedView.Page4Activated += _attachedView_Page4Activated;
            _attachedView.Page5Activated += AttachedViewPage5Activated;
            _attachedView.ResultInVersionChanged += AttachedViewResultInVersionChanged;
        }

        #region Methods

        private void AttachedViewDestinationDirChanged(object sender, string text){
            _destinationFolder = text;
            _attachedView.EnablePage5(!string.IsNullOrEmpty(_destinationFolder));
        }

        private void AttachedViewItemAddedToFiles(object sender, EventArgs e){
            _attachedView.EnablePage4(true);
        }

        private void AttachedViewPage2Activated(object sender, EventArgs e){
            // set version the update will result in ti version it applies and increase the revision number by one
            _appliesTo = _attachedView.AppliesTo;
            _resultsIn = new VersionNumber(_appliesTo.ToString());
            _resultsIn.Revision = Convert.ToString(int.Parse(_resultsIn.Revision) + 1);
            _attachedView.ResultsIn = _resultsIn;
            _attachedView.EnablePage3(true);
        }

        private void AttachedViewPage5Activated(object sender, EventArgs e){
            // compile update and send to final folder for further processing
            // Generate UpdateFile List
            _files = new List<UpdateFile>();
            foreach (UpdateFileDto dto in _attachedView.UpdateFiles) {
                _files.Add(dto.GenerateObject());
            }

            // Pass stuff to service
            _attachedView.FinalUpdateDestination = _generatorService.GenerateUpdate(Path.GetTempPath() + Path.DirectorySeparatorChar + "UpdateGenerator", _destinationFolder, _appliesTo, _resultsIn, _files);
        }

        private void AttachedViewResultInVersionChanged(object sender, VersionNumber versionNumber){
            // check if version is greater than than the version this update applies to
            if (_appliesTo == null || _resultsIn == null) _attachedView.EnablePage3(false);

            int ama = int.Parse(_appliesTo.Major);
            int ami = int.Parse(_appliesTo.Minor);
            int abu = int.Parse(_appliesTo.Build);
            int are = int.Parse(_appliesTo.Revision);
            int rma = int.Parse(_resultsIn.Major);
            int rmi = int.Parse(_resultsIn.Minor);
            int rbu = int.Parse(_resultsIn.Build);
            int rre = int.Parse(_resultsIn.Revision);

            if (ama <= rma && ami <= rmi && abu <= rbu && are <= rre) _attachedView.EnablePage3(true);
            else _attachedView.EnablePage3(false);
        }

        private void _attachedView_Page1Activated(object sender, EventArgs e){
            // do nothing here
        }

        private void _attachedView_Page3Activated(object sender, EventArgs e){
            // do nothing here
        }

        private void _attachedView_Page4Activated(object sender, EventArgs e){
            // do nothing here
        }

        #endregion

        #region Implementation of IBasicViewController

        public IBasicForm GetAttachedForm(){
            return _attachedView;
        }

        #endregion
    }
}