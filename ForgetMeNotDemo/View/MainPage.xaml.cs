using ForgetMeNotDemo.ViewModel;

namespace ForgetMeNotDemo.View
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel vm = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = vm;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm.FullName = "Jesse Liberty";
            vm.Age = "three";
        }


    }

}
