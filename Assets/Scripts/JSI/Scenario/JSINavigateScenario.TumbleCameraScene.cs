using JSI.Cmd;
using UnityEngine;
using X;

namespace JSI.Scenario
{
    public partial class JSINavigateScenario : XScenario
    {
        public class TumbleCameraScene : JSIScene
        {
            // singleton pattern
            private static TumbleCameraScene mSingleton = null;

            public static TumbleCameraScene getSingleton()
            {
                Debug.Assert(TumbleCameraScene.mSingleton != null);
                return TumbleCameraScene.mSingleton;
            }

            public static TumbleCameraScene createSingleton(XScenario scenario)
            {
                Debug.Assert(TumbleCameraScene.mSingleton == null);

                TumbleCameraScene.mSingleton = new TumbleCameraScene(scenario);
                return TumbleCameraScene.mSingleton;
            }

            private TumbleCameraScene(XScenario scenario) : base(scenario)
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
            }

            public override void handlePenDrag(Vector2 pt)
            {
                JSIApp jsi = (JSIApp) this.mScenario.getApp();
                JSICmdToTumbleCamera.execute(jsi);
            }

            public override void handlePenUp(Vector2 pt)
            {
                JSIApp jsi = (JSIApp) this.mScenario.getApp();
                XCmdToChangeScene.execute(jsi, JSINavigateScenario.RotateReadyScene.getSingleton(), this.mReturnScene);
            }
        }
    }
}