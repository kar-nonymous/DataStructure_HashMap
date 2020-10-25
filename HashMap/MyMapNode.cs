using System;
using System.Collections.Generic;
using System.Text;

namespace HashMap
{
    public class MyMapNode<K, V>
    {
        /// <summary>
        /// Structure to define key and value
        /// </summary>
        /// <typeparam name="k"></typeparam>
        /// <typeparam name="v"></typeparam>
        public struct KeyValue<k, v>
        {
            public k Key { get; set; }
            public v Value { get; set; }
        }
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;
        /// <summary>
        /// MyMapNode constructor
        /// </summary>
        /// <param name="size"></param>
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        /// <summary>
        /// Method to return position 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        protected int GetArrayPosition(K key)
        {
            int hash = key.GetHashCode();
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        /// <summary>
        /// Method to return the position
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                    return item.Value;
            }
            return default(V);
        }
        /// <summary>
        /// Method to add element to map
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>()
            { Key = key, Value = value };
            linkedList.AddLast(item);
            Console.WriteLine(item.Key + " " + item.Value);
        }
        /// <summary>
        /// Method to remove element from map
        /// </summary>
        /// <param name="key"></param>
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
        /// <summary>
        /// Method to display the content of the map
        /// </summary>
        public void Display()
        {
            foreach (var linkedList in items)
            {
                if (linkedList != null)
                    foreach (var element in linkedList)
                    {
                        string res = element.ToString();
                        if (res != null)
                            Console.WriteLine(element.Key + " " + element.Value);
                    }
            }
        }
        /// <summary>
        /// UC 1 
        /// Finds frequency of particular value
        /// </summary>
        /// <param name="value">The value.</param>
        public int FindFrequency(V value)
        {
            int count = 0;
            foreach (var linkedList in items)
            {
                if (linkedList != null)
                {
                    foreach (var element in linkedList)
                    {
                        if (element.Value.Equals(value))
                            count++;
                    }
                }
            }
            return count;
        }
        /// <summary>
        /// UC 3
        /// Removes element from the hash map
        /// </summary>
        /// <param name="value"></param>
        public void RemoveData(V value)
        {
            foreach(var linkedList in items)
            {
                if (linkedList != null)
                {
                    KeyValue<K, V>[] keyValue = new KeyValue<K, V>[linkedList.Count];
                    int position = 0;
                    foreach(var element in linkedList)
                    {
                        if(element.Value.Equals(value))
                        {
                            keyValue[position] = element;
                            position++;
                        }
                    }
                    foreach (var element in keyValue)
                        linkedList.Remove(element);
                }
            }
        }
    }
}
