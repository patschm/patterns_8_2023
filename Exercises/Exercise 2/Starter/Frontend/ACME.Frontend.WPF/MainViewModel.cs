using ACME.Frontend.WPF.Core.Base;
using ACME.Frontend.WPF.Core.Interfaces;
using ACME.Frontend.WPF.UserControls.ProductGroupList;

namespace ACME.Frontend.WPF;

public class MainViewModel : BaseViewModel
{
	private IPageView? _currentView;
	
	public MainViewModel()
	{
        // TODO: Navigate to ProductGroupListView
	}

	public IPageView? CurrentView
	{
		get { return _currentView; }
		set 
		{ 
			_currentView = value;
			ChangeProperty();
		}
	}
}
