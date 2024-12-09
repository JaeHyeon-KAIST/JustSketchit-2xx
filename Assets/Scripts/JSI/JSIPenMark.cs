using System.Collections.Generic;
using UnityEngine;

namespace JSI
{
    public class JSIPenMark {
        // fields
        private List<Vector2> mPts = null;

        public List<Vector2> getPts() {
            return this.mPts;
        }

        // private Rectangle mBoundingBox = null;
        //
        // public Rectangle getBoundingBox() {
        //     return this.mBoundingBox;
        // }

        // constructor
        public JSIPenMark(Vector2 pt) {
            this.mPts = new List<Vector2>();
            this.mPts.Add(pt);
            // this.mBoundingBox = new Rectangle(pt.x, pt.y, 0, 0);
        }

        public void addPt(Vector2 pt) {
            this.mPts.Add(pt);
            // this.mBoundingBox.Add(pt);
        }

        public Vector2 getFirstPt() {
            // return this.mPts.get(0);
            return this.mPts[0];
        }

        public Vector2 getLastPt() {
            // return this.mPts[this.mPts.Count - 1];
            return this.mPts[-1];
        }

        public Vector2 getRecentPt(int i)
        {
            int size = this.mPts.Count;
            int index = size - 1 - i;
            Debug.Assert(index >= 0 && index < size);
            return this.mPts[index];
        }
    }
}