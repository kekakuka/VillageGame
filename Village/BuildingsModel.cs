using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village
{
  public  class BuildingsModel
    {
        private BuildingsController _buildingsController;
        public List<AnyBuilding> AnyBuildings { get; set; }

      public  BuildingsModel(BuildingsController buildingsController) {
            _buildingsController = buildingsController;
             AnyBuildings = new List<AnyBuilding>();
        }

        public void AddBuilding(AnyBuilding aBuilding)
        {
            AnyBuildings.Add(aBuilding);
            UpdateViews();
        }

        /// <summary>method: UpdateBuilding
        /// update views
        /// </summary>
        /// <param name="aBuilding"></param>
        public void UpdateBuilding(AnyBuilding aBuilding,int n)
        {
            AnyBuildings[n] = aBuilding;
            UpdateViews();
        }

        /// <summary>method: DeleteBuilding
        /// delete Building and update views
        /// </summary>
        /// <param name="aBuilding"></param>
        public void DeleteBuilding(AnyBuilding aBuilding)
        {
           AnyBuildings.Remove(aBuilding);
            UpdateViews();
        }
        public void UpdateViews()
        {
           _buildingsController.UpdateViews();
        }
    }
}
