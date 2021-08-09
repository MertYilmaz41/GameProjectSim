using System;
using System.Collections.Generic;
using System.Text;
using TryingSomethingNew.Abstract;

namespace TryingSomethingNew.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void AddCampaign()
        {
            Console.WriteLine("Kampanya eklendi.");
        }

        public void DeleteCampaign()
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void UpdateCampaign()
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
