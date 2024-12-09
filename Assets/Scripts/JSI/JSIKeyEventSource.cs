using System.Collections.Generic;
using UnityEngine;

namespace JSI
{
    public class JSIKeyEventSource
    {
        // constants
        private static readonly List<KeyCode> WATCHING_KEYCODE = new List<KeyCode>()
        {
            KeyCode.LeftControl,
            KeyCode.LeftAlt,
            KeyCode.Return
        };

        // fields
        private JSIEventListener mEventListener = null;

        public void setEventListener(JSIEventListener eventListener)
        {
            this.mEventListener = eventListener;
        }
        
        // constructor
        public JSIKeyEventSource()
        {
        }
        
        // methods
        public void update()
        {
            foreach (KeyCode kc in JSIKeyEventSource.WATCHING_KEYCODE)
            {
                if (Input.GetKeyDown(kc))
                {
                    this.mEventListener.keyPressed(kc);
                }

                if (Input.GetKeyUp(kc))
                {
                    this.mEventListener.keyReleased(kc);
                }
            }
        }
    }
}