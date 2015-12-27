using Bridge;
using System;

namespace SLC.Models.Actions
{
    [Namespace(false)]
    public class TestResult {
        [Name(false)]
        public int Id;
        public int groupId;
        public int planId;
        public Date date;
        public TestResultItem[] items;
    }

    [Namespace(false)]
    public class TestResultItem {
        public int contactId;
        public int templateId;
        public string[] errors;
    }
}
