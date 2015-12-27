using Bridge;
using SLC.Models.Actions;

namespace SLC.Campaigns
{
    [Namespace(false)]
    public class TestResultModel : TestResult {
        public static TestResultModel CloneExisting(TestResult template) {
            TestResultModel model = new TestResultModel();
            model.Id = template.Id;
            model.groupId = template.groupId;
            model.planId = template.planId;
            model.date = template.date;            
            model.items = template.items ?? new TestResultItem[0];
            model.hasError = model.items.Length > 0;
            model.intialise();
            return model;
        }

        public string displayDate;
        public string summary;
        public bool hasError;

        private void intialise() {
            if (items.Length == 0) summary = "No Errors";
            else summary = items.Length.ToString() + " Errors";
        }

        public bool toggle(object data, Bridge.Html5.Event e) {
            if (e.Target.TagName == "A") return true;
            return true;
        }
    }
}