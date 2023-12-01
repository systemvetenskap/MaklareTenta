using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Klasser
{
    class Broker
    {
        private List<RealEstate> _realEstates;

        public Broker()
        {
            InitRealEstates();
        }
        private double CalculateRatio(RealEstate realEstate)
        {
            return realEstate.Area / realEstate.Rooms;
        }
        public bool AddRealEstate(RealEstate realEstate)
        {
            double ratio = CalculateRatio(realEstate);
            if (ratio < 10 || ratio > 50)
            {
                return false;

            }int count = _realEstates.Count;
            realEstate.AddId(id: GetNextId());
            _realEstates.Add(realEstate);
            


            if (count + 1 == _realEstates.Count)
            {
                return true;
            }
            return false;
        }
        public List<RealEstate> GetRealEstates(int lowerLimit, int upperLimit)
        {
            List<RealEstate> selectedEstates = new List<RealEstate>();
            foreach (RealEstate estate in _realEstates)
            {
                if(estate.Rooms >= lowerLimit && estate.Rooms <= upperLimit)
                {
                    selectedEstates.Add(estate);
                }
            }
            return selectedEstates;
        }

        public List<RealEstate> GetRealEstates()
        {
            return _realEstates;
        }
        private void InitRealEstates()
        {
            _realEstates = new List<RealEstate>()
            {
                new RealEstate() {Id=1, Address="Gågatan 22", Rooms=1, Area=57},
                new RealEstate() {Id=4, Address="Strandvägen 1",  Rooms=6, Area=125},
                new RealEstate() {Id=5, Address="Humlestigen 14", Rooms=5, Area=125 },
                new RealEstate() {Id=9, Address="Ljunggatan 12 b", Rooms=1, Area=42 }
            };
        }

        private int GetNextId()
        {
            int highestId = int.MinValue;

            foreach (RealEstate estate in _realEstates)
            {
                if (estate.Id > highestId)
                {
                    highestId=estate.Id;
                }
            }
            return highestId+1;
        }
    }
}
