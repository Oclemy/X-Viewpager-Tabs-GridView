package md59673569aad59efe5affe5f4e36f9a467;


public class CrimeFragment
	extends android.support.v4.app.Fragment
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Viewpager_Tabs_GridView.mFrags.CrimeFragment, Viewpager Tabs GridView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CrimeFragment.class, __md_methods);
	}


	public CrimeFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CrimeFragment.class)
			mono.android.TypeManager.Activate ("Viewpager_Tabs_GridView.mFrags.CrimeFragment, Viewpager Tabs GridView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public android.view.View onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2)
	{
		return n_onCreateView (p0, p1, p2);
	}

	private native android.view.View n_onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
