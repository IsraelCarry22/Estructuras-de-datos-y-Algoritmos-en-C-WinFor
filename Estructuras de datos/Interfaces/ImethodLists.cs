namespace Estructuras_de_datos
{
    interface ImethodLists<T>
    {
        void Add(T data);
        void Delete(T data);
        void Search(T data);
        bool Exist(T data);
        void ShowRevers();
        void Show();
        bool IsEmpty();
        void Clear();
    }
}