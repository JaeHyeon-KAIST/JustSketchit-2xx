using UnityEngine;
using X;

namespace JSI.Scenario
{
    public partial class JSINavigateScenario : XScenario
    {
        public class RotateReadyScene : JSIScene
        {
            // singleton pattern
            private static RotateReadyScene mSingleton = null;

            public static RotateReadyScene getSingleton()
            {
                Debug.Assert(RotateReadyScene.mSingleton != null);
                return RotateReadyScene.mSingleton;
            }

            public static RotateReadyScene createSingleton(XScenario scenario)
            {
                Debug.Assert(RotateReadyScene.mSingleton == null);

                RotateReadyScene.mSingleton = new RotateReadyScene(scenario);
                return RotateReadyScene.mSingleton;
            }

            private RotateReadyScene(XScenario scenario) : base(scenario)
            {
            }

            public override void getReady()
            {
            }

            public override void wrapUp()
            {
            }

            public override void handleKeyDown(KeyCode kc)
            {
            }

            public override void handleKeyUp(KeyCode kc)
            {
                JSIApp jsi = (JSIApp) this.mScenario.getApp();
                switch (kc)
                {
                    case KeyCode.LeftAlt:
                        XCmdToChangeScene.execute(jsi, this.mReturnScene, null);
                        break;
                }
            }

            public override void handlePenDown(Vector2 pt)
            {
                JSIApp jsi = (JSIApp) this.mScenario.getApp();
                XCmdToChangeScene.execute(jsi, JSINavigateScenario.TumbleCameraScene.getSingleton(), this.mReturnScene);
            }

            public override void handlePenDrag(Vector2 pt)
            {
            }

            public override void handlePenUp(Vector2 pt)
            {
            }
        }
    }
}