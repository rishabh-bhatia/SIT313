using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace CrossPlatToDo
{
    public class ToDoDatabase
    {
        readonly SQLiteAsyncConnection database;
        //Setting up database
        public ToDoDatabase(String dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<ToDoElement>().Wait();
        }

        public Task<List<ToDoElement>> GetElements()
        {
            return database.Table<ToDoElement>().ToListAsync();
        }
        ////Getting elements which are not marked done
        //public Task<List<ToDoElement>> GeteElementsNotDoneAsync()
        //{
        //    return database.QueryAsync<ToDoElement>("SELECT * FROM [TodoElement] WHERE [Done] = 0");
        //}
        //Access a particular element
        public Task<ToDoElement> GetElement(int id)
        {
            return database.Table<ToDoElement>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }
        //Saving a new element or modifying an element in the database
        public Task<int> SaveElement(ToDoElement element)
        {
            if (element.ID != 0)
            {
                return database.UpdateAsync(element);
            }
            else
            {
                return database.InsertAsync(element);
            }
        }
        //Deleting element from database
        public Task<int> DeleteElement(ToDoElement element)
        {
            return database.DeleteAsync(element);
        }
    }
}
