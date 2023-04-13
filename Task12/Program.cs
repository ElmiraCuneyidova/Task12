using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Task12
{
    internal class Program
    {

    }
    #region task1

    //1.İstənilən növ oyun obyektinin kolleksiyasını saxlayan və kolleksiyaya
    //yeni obyektlər əlavə etmək üçün metod təqdim edən “generic class”
    //yaradın.

    public class Task1<T>
    {
        public List<T> GameObject { get; set; }
        public void AddObject(T gameObject)
        {
            GameObject.Add(gameObject);
        }
    }



    #endregion


    #region Task2

    //2. Hücum, zədələnmə və müalicə(attacking, taking damage, healing)
    //metodlarını özündə birləşdirən character sinfi üçün "generic interface"
    //yaradın.



    public interface Generic<T>
    {

    }
    public class Character : Generic<int>
    {
        private int Attack;
        private int Damage;
        private int Healing;

    }


    #endregion


    #region Task3

    //3. Oyunda oyunçunun inventarını təmsil edən "generic class" tətbiq
    //edin.Class istənilən növ elementi saxlamağı bacarmalı və elementləri
    //əlavə etmək, silmək və çeşidləmək metodlarını təmin etməlidir.
    public class Invent<T>
    {
        public T AddElement;
        public T RemoveElement;
        public T SortElement;

        public Invent (T addElement, T removeElement, T sortElement )
        {
            AddElement = addElement;
            RemoveElement = removeElement;
            SortElement = sortElement;
        }
    }

    #endregion


    





}
