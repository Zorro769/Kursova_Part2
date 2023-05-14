using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovrPart2
{
    public class BigIntArray : IEnumerable, IEnumerator
    {
        private List<BigIntValues> bigIntValues;
        private int Count = 0;
        private int index = -1;

        public BigIntArray()
        {
            bigIntValues = new List<BigIntValues>();
        }
        public BigIntArray(int count)
        {
            bigIntValues = new List<BigIntValues>();
            Count = count;
        }
        ~BigIntArray() { }
        public IEnumerator GetEnumerator()
        {
            foreach (BigIntValues bgInt in bigIntValues)
            {
                yield return bgInt;
            }
        }
        public bool MoveNext()
        {
            if (index == bigIntValues.Count - 1)
            {
                Reset();
                return false;
            }
            index++;
            return true;
        }
        public void Reset()
        {
            index = -1;
        }
        public object Current
        {
            get
            {
                return bigIntValues.ElementAt(index);
            }
        }
        public List<BigIntValues> GetValue()
        {
            return bigIntValues;
        }
        public int GetSize()
        {
            return bigIntValues.Count;
        }
        public void AddValue(string pStrStart)
        {
            bigIntValues.Add(new BigIntValues(pStrStart));
        }
        public BigIntValues AllObjSum()
        {
            BigIntValues result = new BigIntValues("0");
            for (int i = 0; i < bigIntValues.Count; i++)
            {
                result = result + bigIntValues[i];
            }
            return new BigIntValues(result);
        }
    }
}
