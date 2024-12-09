using UnityEngine;
using X;

namespace JSI.Scenario
{
    public partial class JSIEmptyScenario : XScenario
    {
        public class ReadyScene : JSIScene
        {
            // singleton pattern
            private static ReadyScene mSingleton = null;

            public static ReadyScene getSingleton()
            {
                Debug.Assert(ReadyScene.mSingleton != null);
                return ReadyScene.mSingleton;
            }

            public static ReadyScene createSingleton(XScenario scenario)
            {
                Debug.Assert(ReadyScene.mSingleton == null);

                ReadyScene.mSingleton = new ReadyScene(scenario);
                return ReadyScene.mSingleton;
            }

            private ReadyScene(XScenario scenario) : base(scenario)
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
            }

            public override void handlePenDown(Vector2 pt)
            {
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