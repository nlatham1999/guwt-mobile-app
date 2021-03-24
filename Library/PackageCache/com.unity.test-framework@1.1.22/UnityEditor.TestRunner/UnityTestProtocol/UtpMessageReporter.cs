<<<<<<< HEAD:Library/PackageCache/com.unity.test-framework@1.1.22/UnityEditor.TestRunner/UnityTestProtocol/UtpMessageReporter.cs
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Compilation;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class UtpMessageReporter : IUtpMessageReporter
    {
        public ITestRunnerApiMapper TestRunnerApiMapper;
        public IUtpLogger Logger;

        public UtpMessageReporter(IUtpLogger utpLogger)
        {
            TestRunnerApiMapper = new TestRunnerApiMapper();
            Logger = utpLogger;
        }

        public void ReportTestRunStarted(ITestAdaptor testsToRun)
        {
            var msg = TestRunnerApiMapper.MapTestToTestPlanMessage(testsToRun);

            Logger.Log(msg);
        }

        public void ReportTestStarted(ITestAdaptor test)
        {
            if (test.IsSuite)
                return;

            var msg = TestRunnerApiMapper.MapTestToTestStartedMessage(test);

            Logger.Log(msg);
        }

        public void ReportTestFinished(ITestResultAdaptor result)
        {
            if (result.Test.IsSuite)
                return;

            var msg = TestRunnerApiMapper.TestResultToTestFinishedMessage(result);

            Logger.Log(msg);
        }
    }
}
=======
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Compilation;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class UtpMessageReporter : IUtpMessageReporter
    {
        public ITestRunnerApiMapper TestRunnerApiMapper;
        public IUtpLogger Logger;

        public UtpMessageReporter(IUtpLogger utpLogger)
        {
            TestRunnerApiMapper = new TestRunnerApiMapper();
            Logger = utpLogger;
        }

        public void ReportTestRunStarted(ITestAdaptor testsToRun)
        {
            var msg = TestRunnerApiMapper.MapTestToTestPlanMessage(testsToRun);

            Logger.Log(msg);
        }

        public void ReportTestStarted(ITestAdaptor test)
        {
            if (test.IsSuite)
                return;

            var msg = TestRunnerApiMapper.MapTestToTestStartedMessage(test);

            Logger.Log(msg);
        }

        public void ReportTestFinished(ITestResultAdaptor result)
        {
            if (result.Test.IsSuite)
                return;

            var msg = TestRunnerApiMapper.TestResultToTestFinishedMessage(result);

            Logger.Log(msg);
        }
    }
}
>>>>>>> 311c70c6976bc5ea11bafc9e95d3e0e4ee456de5:Library/PackageCache/com.unity.test-framework@1.1.20/UnityEditor.TestRunner/UnityTestProtocol/UtpMessageReporter.cs
