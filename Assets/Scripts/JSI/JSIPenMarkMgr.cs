using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace JSI
{
    public class JSIPenMarkMgr
    {
        // constants
        private static readonly int MAX_NUM_PEN_MARKS = 10;

        // fields
        private List<JSIPenMark> mPanMarks = null;

        public List<JSIPenMark> getPanMarks()
        {
            return this.mPanMarks;
        }

        // constructor
        public JSIPenMarkMgr()
        {
            this.mPanMarks = new List<JSIPenMark>();
        }

        public void addPenMark(JSIPenMark panMark)
        {
            if (this.mPanMarks.Count >= MAX_NUM_PEN_MARKS)
            {
                this.mPanMarks.RemoveAt(0);
            }

            this.mPanMarks.Add(panMark);
        }

        public JSIPenMark getLastPenMark()
        {
            int size = this.mPanMarks.Count;
            if (this.mPanMarks.Count == 0)
            {
                return null;
            }

            return this.mPanMarks[size - 1];
        }

        public JSIPenMark getRecentPenMark(int i)
        {
            int size = this.mPanMarks.Count;
            if (size == 0 || i >= size)
            {
                return null;
            }

            return this.mPanMarks[size - i - 1];
        }

        public bool handlePenDown(Vector2 pt)
        {
            JSIPenMark panMark = new JSIPenMark(pt);
            this.addPenMark(panMark);
            return true;
        }

        public bool handlePenDrag(Vector2 pt)
        {
            JSIPenMark panMark = this.getLastPenMark();
            if (panMark == null)
            {
                return false;
            }

            panMark.addPt(pt);
            return true;
        }

        public bool handlePenUp(Vector2 pt)
        {
            return true;
        }
    }
}