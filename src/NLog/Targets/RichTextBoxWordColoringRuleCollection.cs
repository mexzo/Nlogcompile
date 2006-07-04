// 
// Copyright (c) 2004-2006 Jaroslaw Kowalski <jaak@jkowalski.net>
// 
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// * Redistributions of source code must retain the above copyright notice, 
//   this list of conditions and the following disclaimer. 
// 
// * Redistributions in binary form must reproduce the above copyright notice,
//   this list of conditions and the following disclaimer in the documentation
//   and/or other materials provided with the distribution. 
// 
// * Neither the name of Jaroslaw Kowalski nor the names of its 
//   contributors may be used to endorse or promote products derived from this
//   software without specific prior written permission. 
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE 
// ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE 
// LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
// CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
// SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
// INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN 
// CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
// ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF 
// THE POSSIBILITY OF SUCH DAMAGE.
// 
#if !NETCF

using System;

namespace NLog.Targets
{
    /// <summary>
    /// A collection of elements of type RichTextBoxWordColoringRule
    /// </summary>
    public class RichTextBoxWordColoringRuleCollection: System.Collections.CollectionBase
    {
        /// <summary>
        /// Initializes a new empty instance of the RichTextBoxWordColoringRuleCollection class.
        /// </summary>
        public RichTextBoxWordColoringRuleCollection()
        {
            // empty
        }

        /// <summary>
        /// Initializes a new instance of the RichTextBoxWordColoringRuleCollection class, containing elements
        /// copied from an array.
        /// </summary>
        /// <param name="items">
        /// The array whose elements are to be added to the new RichTextBoxWordColoringRuleCollection.
        /// </param>
        public RichTextBoxWordColoringRuleCollection(RichTextBoxWordColoringRule[] items)
        {
            this.AddRange(items);
        }

        /// <summary>
        /// Initializes a new instance of the RichTextBoxWordColoringRuleCollection class, containing elements
        /// copied from another instance of RichTextBoxWordColoringRuleCollection
        /// </summary>
        /// <param name="items">
        /// The RichTextBoxWordColoringRuleCollection whose elements are to be added to the new RichTextBoxWordColoringRuleCollection.
        /// </param>
        public RichTextBoxWordColoringRuleCollection(RichTextBoxWordColoringRuleCollection items)
        {
            this.AddRange(items);
        }

        /// <summary>
        /// Adds the elements of an array to the end of this RichTextBoxWordColoringRuleCollection.
        /// </summary>
        /// <param name="items">
        /// The array whose elements are to be added to the end of this RichTextBoxWordColoringRuleCollection.
        /// </param>
        public virtual void AddRange(RichTextBoxWordColoringRule[] items)
        {
            foreach (RichTextBoxWordColoringRule item in items)
            {
                this.List.Add(item);
            }
        }

        /// <summary>
        /// Adds the elements of another RichTextBoxWordColoringRuleCollection to the end of this RichTextBoxWordColoringRuleCollection.
        /// </summary>
        /// <param name="items">
        /// The RichTextBoxWordColoringRuleCollection whose elements are to be added to the end of this RichTextBoxWordColoringRuleCollection.
        /// </param>
        public virtual void AddRange(RichTextBoxWordColoringRuleCollection items)
        {
            foreach (RichTextBoxWordColoringRule item in items)
            {
                this.List.Add(item);
            }
        }

        /// <summary>
        /// Adds an instance of type RichTextBoxWordColoringRule to the end of this RichTextBoxWordColoringRuleCollection.
        /// </summary>
        /// <param name="value">
        /// The RichTextBoxWordColoringRule to be added to the end of this RichTextBoxWordColoringRuleCollection.
        /// </param>
        public virtual void Add(RichTextBoxWordColoringRule value)
        {
            this.List.Add(value);
        }

        /// <summary>
        /// Determines whether a specfic RichTextBoxWordColoringRule value is in this RichTextBoxWordColoringRuleCollection.
        /// </summary>
        /// <param name="value">
        /// The RichTextBoxWordColoringRule value to locate in this RichTextBoxWordColoringRuleCollection.
        /// </param>
        /// <returns>
        /// true if value is found in this RichTextBoxWordColoringRuleCollection;
        /// false otherwise.
        /// </returns>
        public virtual bool Contains(RichTextBoxWordColoringRule value)
        {
            return this.List.Contains(value);
        }

        /// <summary>
        /// Return the zero-based index of the first occurrence of a specific value
        /// in this RichTextBoxWordColoringRuleCollection
        /// </summary>
        /// <param name="value">
        /// The RichTextBoxWordColoringRule value to locate in the RichTextBoxWordColoringRuleCollection.
        /// </param>
        /// <returns>
        /// The zero-based index of the first occurrence of the _ELEMENT value if found;
        /// -1 otherwise.
        /// </returns>
        public virtual int IndexOf(RichTextBoxWordColoringRule value)
        {
            return this.List.IndexOf(value);
        }

        /// <summary>
        /// Inserts an element into the RichTextBoxWordColoringRuleCollection at the specified index
        /// </summary>
        /// <param name="index">
        /// The index at which the RichTextBoxWordColoringRule is to be inserted.
        /// </param>
        /// <param name="value">
        /// The RichTextBoxWordColoringRule to insert.
        /// </param>
        public virtual void Insert(int index, RichTextBoxWordColoringRule value)
        {
            this.List.Insert(index, value);
        }

        /// <summary>
        /// Gets or sets the RichTextBoxWordColoringRule at the given index in this RichTextBoxWordColoringRuleCollection.
        /// </summary>
        public virtual RichTextBoxWordColoringRule this[int index]
        {
            get { return (RichTextBoxWordColoringRule) this.List[index]; }
            set { this.List[index] = value; }
        }

        /// <summary>
        /// Removes the first occurrence of a specific RichTextBoxWordColoringRule from this RichTextBoxWordColoringRuleCollection.
        /// </summary>
        /// <param name="value">
        /// The RichTextBoxWordColoringRule value to remove from this RichTextBoxWordColoringRuleCollection.
        /// </param>
        public virtual void Remove(RichTextBoxWordColoringRule value)
        {
            this.List.Remove(value);
        }

        /// <summary>
        /// Type-specific enumeration class, used by RichTextBoxWordColoringRuleCollection.GetEnumerator.
        /// </summary>
        public class Enumerator: System.Collections.IEnumerator
        {
            private System.Collections.IEnumerator wrapped;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="collection"></param>
            public Enumerator(RichTextBoxWordColoringRuleCollection collection)
            {
                this.wrapped = ((System.Collections.CollectionBase)collection).GetEnumerator();
            }

            /// <summary>
            /// 
            /// </summary>
            public RichTextBoxWordColoringRule Current
            {
                get { return (RichTextBoxWordColoringRule) (this.wrapped.Current); }
            }

            object System.Collections.IEnumerator.Current
            {
                get { return (RichTextBoxWordColoringRule) (this.wrapped.Current); }
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public bool MoveNext()
            {
                return this.wrapped.MoveNext();
            }

            /// <summary>
            /// 
            /// </summary>
            public void Reset()
            {
                this.wrapped.Reset();
            }
        }

        /// <summary>
        /// Returns an enumerator that can iterate through the elements of this RichTextBoxWordColoringRuleCollection.
        /// </summary>
        /// <returns>
        /// An object that implements System.Collections.IEnumerator.
        /// </returns>        
        public new virtual RichTextBoxWordColoringRuleCollection.Enumerator GetEnumerator()
        {
            return new RichTextBoxWordColoringRuleCollection.Enumerator(this);
        }
    }
}
#endif