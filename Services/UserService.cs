using apirest.Models;
using System.Collections.Generic;

namespace apirest.Services
{
    public class UserService
    {
        private static List<User> banco;
        private int nextId;

        public UserService()
        {
           banco = new List<User>(); 
           banco.Add(new User(1, "Guilherme Henrique", 19, "1317144554"));
           nextId = 2;
        }

        public List<User> GetUsers()
        {
            return banco;
        }

        public User GetUser(int id)
        {
            return banco.Find(u => u.Id == id);
        }

        public User PostUser(User user)
        {
            user.Id = nextId;
            banco.Add(user);
            nextId += 1;
            return user;
        }
        public User UpdateUser(User updatedUser, int id)
        {
            User oldUser = banco.Find(u => u.Id == id);
            updatedUser.Id = id;
            banco.Insert(banco.IndexOf(oldUser), updatedUser);
            return updatedUser;
        }

        public string DeleteUser(int id)
        {
            banco.Remove(banco.Find(u => u.Id == id));
            return "Usuário apagado com sucesso";
        }
    }
}
