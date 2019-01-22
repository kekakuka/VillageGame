using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village
{
  public  class BuildingsController
    {
 

        private ArrayList ViewList;

        // constructor
        public BuildingsController()
        {
            // ViewList = new ArrayList();           
            ViewList = new ArrayList();

        }

        /// <summary>method: AddView
        /// add view to viewlist
        /// </summary>
        /// <param name="aView"></param>
        public void AddView(IBuildingViews aView)
        {
            ViewList.Add(aView);
        }

        /// <summary>method: UpdateViews
        /// update each view 
        /// </summary>
        public void UpdateViews()
        {
            IBuildingViews[] theViews = (IBuildingViews[])ViewList.ToArray(typeof(IBuildingViews));
            foreach (IBuildingViews v in theViews)
            {
                v.RefreshViews();
            }
        }

       


     
    }
}
