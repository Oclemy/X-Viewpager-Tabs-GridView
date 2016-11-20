using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Viewpager_Tabs_GridView.mFrags;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentManager = Android.Support.V4.App.FragmentManager;
using FragmentTransaction = Android.App.FragmentTransaction;


namespace Viewpager_Tabs_GridView
{
    [Activity(Label = "Viewpager_Tabs_GridView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : FragmentActivity,ActionBar.ITabListener
    {
        private ActionBar ab;
        private ViewPager vp;
        private FragmentManager fm;
        private MyPagerAdapter adapter;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //ACTIONBAR
            ab = this.ActionBar;
            ab.SetDisplayShowTitleEnabled(true);
            ab.NavigationMode=ActionBarNavigationMode.Tabs;

            //FRAGMENT MANAGER
            fm = this.SupportFragmentManager;

            //ADAPTER
            adapter=new MyPagerAdapter(fm,getFragments());

            //VIEWPAGER
            vp = FindViewById<ViewPager>(Resource.Id.pager);
            vp.PageSelected += vp_PageSelected;
            vp.Adapter = adapter;

            //ADD TABS
            addTabs();

        }

        void vp_PageSelected(object sender, ViewPager.PageSelectedEventArgs e)
        {
            ab.SetSelectedNavigationItem(e.Position);
        }

        private JavaList<Fragment> getFragments()
        {
            JavaList<Fragment> fragments=new JavaList<Fragment>();
            fragments.Add(new CrimeFragment());
            fragments.Add(new DramaFragment());
            fragments.Add(new DocumentaryFragment());

            return fragments;

        }

        //ADD TABS
        private void addTabs()
        {
            ActionBar.Tab t = ab.NewTab().SetText("Crime").SetIcon(Resource.Drawable.oranges).SetTabListener(this);
            ab.AddTab(t);
            t = ab.NewTab().SetText("Drama").SetIcon(Resource.Drawable.mango).SetTabListener(this);
            ab.AddTab(t);
            t = ab.NewTab().SetText("Documentary").SetIcon(Resource.Drawable.coconut).SetTabListener(this);
            ab.AddTab(t);
        }


        public void OnTabReselected(ActionBar.Tab tab, FragmentTransaction ft)
        {
            
        }

        public void OnTabSelected(ActionBar.Tab tab, FragmentTransaction ft)
        {
            vp.CurrentItem = tab.Position;
        }

        public void OnTabUnselected(ActionBar.Tab tab, FragmentTransaction ft)
        {
            
        }
    }
}

