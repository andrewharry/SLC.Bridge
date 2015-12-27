using Bridge;
using Bridge.Html5;
using SLC.Models.Actions;

namespace SLC.Campaigns
{
    [Namespace(false)]
    public class TestResultController {
        public TestResultController(int table, int planId) {
            this.planId = planId;
        }

        private object convert(object data) {
            return TestResultModel.CloneExisting((TestResult)data);
        }

        private int planId;

        private void errors(string error) {
            Window.Alert(error);
        }
    }
}
