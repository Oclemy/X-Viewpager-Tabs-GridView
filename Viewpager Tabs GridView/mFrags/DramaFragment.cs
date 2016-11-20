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
    class DramaFragment : Fragment
    {
        private GridView gv;
        private ArrayAdapter adapter;
        private String[] drama = { "Banshee", "Hannibal", "Burn Notice", "Men In Black", "Game of Thrones", "Blindspot" };

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View rootView = inflater.Inflate(Resource.Layout.dramalayout, container, false);

            gv = rootView.FindViewById<GridView>(Resource.Id.dramaLv);
            adapter=new ArrayAdapter(this.Activity,Android.Resource.Layout.SimpleListItem1,drama);
            gv.Adapter = adapter;
            gv.ItemClick += gv_ItemClick;
            return rootView;
        }

        void gv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this.Activity, drama[e.Position], ToastLength.Short).Show();
        }
    }
}