using MvvmCross.Forms.Views.Attributes;

namespace MobileTabTest.Core.Core.Pages
{
    [MvxTabbedPagePresentation(TabbedPosition.Root)]
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private bool _firstTime = true;

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (_firstTime)
            {
                //ViewModel.ShowInitialViewModelsCommand.Execute();
                ViewModel.ShowInitialViewModelsCommand.ExecuteAsync(null);
                _firstTime = false;
            }
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();

        }
    }
}
