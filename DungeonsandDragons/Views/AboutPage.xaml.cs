using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DungeonsandDragons.Models;


namespace DungeonsandDragons
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        /*
        public void SetDataSource(bool isMock)
        {
            if (isMock == true)
            {
                ItemsViewModel.Instance.SetDataStore(BaseViewModel.DataStoreEnum.Mock);
                MonstersViewModel.Instance.SetDataStore(BaseViewModel.DataStoreEnum.Mock);
                CharactersViewModel.Instance.SetDataStore(BaseViewModel.DataStoreEnum.Mock);
                ScoresViewModel.Instance.SetDataStore(BaseViewModel.DataStoreEnum.Mock);
            }
            else
            {
                ItemsViewModel.Instance.SetDataStore(BaseViewModel.DataStoreEnum.Sql);
                MonstersViewModel.Instance.SetDataStore(BaseViewModel.DataStoreEnum.Sql);
                CharactersViewModel.Instance.SetDataStore(BaseViewModel.DataStoreEnum.Sql);
                ScoresViewModel.Instance.SetDataStore(BaseViewModel.DataStoreEnum.Sql);
            }

            // Have data refresh...
            ItemsViewModel.Instance.SetNeedsRefresh(true);
            MonstersViewModel.Instance.SetNeedsRefresh(true);
            CharactersViewModel.Instance.SetNeedsRefresh(true);
            ScoresViewModel.Instance.SetNeedsRefresh(true);
        }

 */


        public void DebugSettings_OnToggled(object sender, ToggledEventArgs e)
        {
            Stack1.IsVisible = !Stack1.IsVisible;
            Stack2.IsVisible = !Stack2.IsVisible;
            Stack3.IsVisible = !Stack3.IsVisible;
            Stack4.IsVisible = !Stack4.IsVisible;
            Stack5.IsVisible = !Stack5.IsVisible;
            Stack6.IsVisible = !Stack6.IsVisible;
            Label1.IsVisible = !Label1.IsVisible;
        }

        public void HealingDebug_OnToggled(object sender, ToggledEventArgs e)
        {
            if (HealingDebug.IsToggled == true)
            {
                DebugSetting.AllowRoundHealing = true;
            }
            else
            {
                DebugSetting.AllowRoundHealing = false;
            }
        }

        public void UseMock_OnToggled(object sender, ToggledEventArgs e)
        {
            //SetDataSource(e.Value);
        }

        public void UsePOST_OnToggled(object sender, ToggledEventArgs e)
        {

        }

        public void DisableRandom_OnToggled(object sender, ToggledEventArgs e)
        {

        }

        public void Enable1_OnToggled(object sender, ToggledEventArgs e)
        {

        }

        public void Enable20_OnToggled(object sender, ToggledEventArgs e)
        {

        }
    }
}
