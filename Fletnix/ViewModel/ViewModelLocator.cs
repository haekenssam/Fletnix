using Autofac;
using Fletnix.Services.Infrastructure;

namespace Fletnix.ViewModel
{
    public class ViewModelLocator
    {
        private readonly IContainer _container;

        public ViewModelLocator()
        {
            //autofac
            var builder = new ContainerBuilder();
            builder.RegisterModule<ServicesModule>();
            
            //CatalogItems
            builder.RegisterType<MainViewModel>().SingleInstance();
            builder.RegisterType<CreateCatalogItemViewModel>().SingleInstance();
            builder.RegisterInstance(new CatalogItemDetailViewModel()).SingleInstance();

            //Userprofiles
            builder.RegisterType<UserprofileViewModel>().SingleInstance();
            builder.RegisterType<CreateUserprofileViewModel>().SingleInstance();

            _container = builder.Build();
            _container.Resolve<MainViewModel>();

            #region IoC
            // Inversion Of Control pattern
            // Dependency Injection
            //SimpleIoc.Default.Register<ICatalogService, CatalogService>();
            //SimpleIoc.Default.Register<MainViewModel>();
            //SimpleIoc.Default.Register<CreateCatalogItemViewModel>();
            //SimpleIoc.Default.Register<CatalogItemDetailViewModel>(true); 
            #endregion
        }

        //CatalogItems
        public MainViewModel Main => _container.Resolve<MainViewModel>();
        public CreateCatalogItemViewModel CreateCatalogItem => _container.Resolve<CreateCatalogItemViewModel>();
        public CatalogItemDetailViewModel CatalogItemDetail => _container.Resolve<CatalogItemDetailViewModel>();
        
        //Userprofiles
        public UserprofileViewModel Userprofile => _container.Resolve<UserprofileViewModel>();
        public CreateUserprofileViewModel CreateUserprofile => _container.Resolve<CreateUserprofileViewModel>();
    }
}
