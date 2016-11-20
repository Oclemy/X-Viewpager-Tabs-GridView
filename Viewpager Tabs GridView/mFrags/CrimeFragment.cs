using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;

namespace Viewpager_Tabs_GridView.mFrags
{
    class CrimeFragment : Fragment
    {
        private GridView gv;
        private ArrayAdapter adapter;
        private String[] crime = { "BlackList", "Gotham", "Crisis", "Banshee", "Breaking Bad" };

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View rootView = inflater.Inflate(Resource.Layout.crimelayout, container, false);

            gv = rootView.FindViewById<GridView>(Resource.Id.crimeLv);
            adapter=new ArrayAdapter(this.Activity,Android.Resource.Layout.SimpleListItem1,crime);

            gv.Adapter = adapter;

            gv.ItemClick += gv_ItemClick;

            return rootView;
        }

        void gv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this.Activity,crime[e.Position],ToastLength.Short).Show();
        }
    }
}