using UnityEngine;

namespace JSI
{
    public class JSIMouseEventSource
    {
        // constants
        private static readonly int LEFT_BUTTON = 0;
        private static readonly int RIGHT_BUTTON = 1;
        
        // fields
        private JSIEventListener mEventListener = null;
        public void setEventListener(JSIEventListener eventListener)
        {
            this.mEventListener = eventListener;
        }
        
        private bool mWasLeftPressed = false;
        private bool mIsLeftPressed = false;
        private bool mWasRightPressed = false;
        private bool mIsRightPressed = false;
        private Vector2 mPrevPt = Vector2.zero;
        private Vector2 mCurPt = Vector2.zero;
        
        // constructor
        public JSIMouseEventSource()
        {
        }
        
        // methods
        public void update()
        {
            this.mIsLeftPressed = Input.GetMouseButton(JSIMouseEventSource.LEFT_BUTTON);
            this.mIsRightPressed = Input.GetMouseButton(JSIMouseEventSource.RIGHT_BUTTON);
            this.mCurPt = Input.mousePosition;

            if (!this.mIsLeftPressed && !this.mIsRightPressed && this.mPrevPt != this.mCurPt)
            {
                this.mEventListener.mouseMoved(this.mCurPt);
            }
            if (!this.mWasLeftPressed && this.mIsLeftPressed)
            {
                this.mEventListener.mouseLeftPressed(this.mCurPt);
            }
            if (this.mWasLeftPressed && this.mIsLeftPressed && this.mPrevPt != this.mCurPt)
            {
                this.mEventListener.mouseLeftDragged(this.mCurPt);
            }
            if (this.mWasLeftPressed && !this.mIsLeftPressed)
            {
                this.mEventListener.mouseLeftReleased(this.mCurPt);
            }
            if (!this.mWasRightPressed && this.mIsRightPressed)
            {
                this.mEventListener.mouseRightPressed(this.mCurPt);
            }
            if (this.mWasRightPressed && this.mIsRightPressed && this.mPrevPt != this.mCurPt)
            {
                this.mEventListener.mouseRightDragged(this.mCurPt);
            }
            if (this.mWasRightPressed && !this.mIsRightPressed)
            {
                this.mEventListener.mouseRightReleased(this.mCurPt);
            }
            
            // updates the previous state
            this.mWasLeftPressed = this.mIsLeftPressed;
            this.mWasRightPressed = this.mIsRightPressed;
            this.mPrevPt = this.mCurPt;
        }
    }
}