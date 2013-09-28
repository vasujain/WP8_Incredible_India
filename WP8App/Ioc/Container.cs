// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   UnityContainer.tt
using Microsoft.Practices.Unity;
using WPAppStudio.Ioc.Interfaces;
using WPAppStudio.Repositories;
using WPAppStudio.Repositories.Base;
using WPAppStudio.Services;
using WPAppStudio.Services.Interfaces;
using WPAppStudio.ViewModel;
using WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.Ioc
{
    //
    // Unity 2.1
    // http://msdn.microsoft.com/en-us/library/hh237493.aspx
    //
    // patterns & practices - Unity
    // http://unity.codeplex.com/
    //
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public class Container : IContainer
    {
        private readonly IUnityContainer _currentContainer;

        public Container()
        {
            _currentContainer = new UnityContainer();

            _currentContainer.RegisterType<ILiveTileService, LiveTileService>();
			_currentContainer.RegisterType<ILockScreenService, LockScreenService>();
            _currentContainer.RegisterType<IDialogService, DialogService>();
            _currentContainer.RegisterType<IReminderService, ReminderService>();
            _currentContainer.RegisterType<IShareService, ShareService>();
            _currentContainer.RegisterType<ISpeechService, SpeechService>();
            _currentContainer.RegisterType<INavigationService, NavigationService>();
			_currentContainer.RegisterType<IJsonDataSource, JsonDataSource>();
			_currentContainer.RegisterType<IXmlDataSource, XmlDataSource>();
			_currentContainer.RegisterType<IYoutubeDataSource, YoutubeDataSource>();
			
            _currentContainer.RegisterType<IAboutIndiaViewModel, AboutIndiaViewModel>();
            _currentContainer.RegisterType<IVideoAlbum_DetailVideosViewModel, VideoAlbum_DetailVideosViewModel>();
            _currentContainer.RegisterType<IPhotoAlbum_DetailViewModel, PhotoAlbum_DetailViewModel>();
            _currentContainer.RegisterType<Imonuments_DetailViewModel, monuments_DetailViewModel>();
            _currentContainer.RegisterType<IDisclaimer_InfoViewModel, Disclaimer_InfoViewModel>();
			
			if (!System.ComponentModel.DesignerProperties.IsInDesignTool)
            {
				_currentContainer.RegisterType<Iinfo, info>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<ImonumentsCollection, monumentsCollection>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Ialbum, album>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IvideoAlbum, videoAlbum>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Idisclaimer, disclaimer>(new ContainerControlledLifetimeManager());
			}
			else
			{
				_currentContainer.RegisterType<Iinfo, Fakeinfo>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<ImonumentsCollection, FakemonumentsCollection>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Ialbum, Fakealbum>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IvideoAlbum, FakevideoAlbum>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Idisclaimer, Fakedisclaimer>(new ContainerControlledLifetimeManager());
			
			}	
        }

        public T Resolve<T>()
        {
            return _currentContainer.Resolve<T>();
        }
    }
}
