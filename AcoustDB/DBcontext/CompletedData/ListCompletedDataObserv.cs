using ModelsForCollectionItems;
using System.Linq;

namespace DBcontext
{
    public class ListCompletedDataObserv : BaseModelForListItems<AllStageObj>
    {
        public ListCompletedDataObserv()
        {

        }

        public override void AddNewItem()
        {
            Collection.Add(new AllStageObj());
            SelectedItem = Collection.Last();
        }
    }
}
