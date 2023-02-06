using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace OOP_TruongMauGiao
{
    class CommandGenerator
    {
        /*
            EXAMPLE USING INSERT, UPDATE, DELETE COMMAND:
            MySqlCommand command = CommandGenerator.addRegister(registerInfo);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;

            EXAMPLE USING SELECT COMMAND:
            MySqlCommand command = CommandGenerator.login(mail, password);
            MySqlDataToDataTableAdapter adapter = new MySqlDataToDataTableAdapter(command);
            DataTable table = adapter.getDataTable();
        */
        #region User
        public static MySqlCommand login(string mail, string password)
        {
            //SELECT sql command to get all data that match User's login mail and password
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `Mail`= @mail AND `Password`= @pass", DatabaseConnector.getConnection);
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = SHA256Encryptor.encrypt(password);
            return command;
        }

        /*
        public static MySqlCommand addRegister(UserInfo registerInfo)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `register`(`Mail`, `Password`, `PhoneNumber`, `Address`, `Gender`, `Name`, `Avatar`, `Birthday`, `SendRegistrationTime`)" +
                                                    "VALUES                (@Mail,@Password,@PhoneNumber,@Address,@Gender,@Name,@Avatar,@Birthday,@SendRegistrationTime)",
                                                    DatabaseConnector.getConnection);
            command.Parameters.Add("@Mail", MySqlDbType.VarChar).Value = registerInfo.mail;
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = SHA256Encryptor.encrypt(registerInfo.password);
            command.Parameters.Add("@PhoneNumber", MySqlDbType.VarChar).Value = registerInfo.phoneNumber;
            command.Parameters.Add("@Address", MySqlDbType.VarChar).Value = registerInfo.address;
            command.Parameters.Add("@Gender", MySqlDbType.VarChar).Value = registerInfo.gender;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = registerInfo.name;
            command.Parameters.Add("@Avatar", MySqlDbType.LongBlob).Value = registerInfo.avatar.ToArray();
            command.Parameters.Add("@Birthday", MySqlDbType.Date).Value = registerInfo.birthday;
            command.Parameters.Add("@SendRegistrationTime", MySqlDbType.DateTime).Value = DateTime.Now;
            return command;
        }
        */
        public static MySqlCommand updateUserInfo(UserInfo userInfo)
        {
            //MySqlCommand command = new MySqlCommand("UPDATE `user` SET `Mail`='@Mail',`Password`='@Password',`PhoneNumber`='@PhoneNumber',`Address`='@Address',`Role`='@Role',`Gender`='@Gender',`Name`='@Name',`Avatar`='@Avatar',`Birthday`='@Birthday'" +
            //                                        "WHERE `Id`= @Id", DatabaseConnector.getConnection);
            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `PhoneNumber`= @PhoneNumber, `Mail`= @Mail, `Role`= @Role, `Address`= @Address, `Gender`= @Gender,`Name`= @Name,`Avatar`= @Avatar,`Birthday`= @Birthday " +
                                                    "WHERE `Id`= @Id", DatabaseConnector.getConnection);
            command.Parameters.Add("@Id", MySqlDbType.VarChar).Value = userInfo.id;
            command.Parameters.Add("@Mail", MySqlDbType.VarChar).Value = userInfo.mail;
            //command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = SHA256Encryptor.encrypt(userInfo.password);
            command.Parameters.Add("@PhoneNumber", MySqlDbType.VarChar).Value = userInfo.phoneNumber;
            command.Parameters.Add("@Address", MySqlDbType.VarChar).Value = userInfo.address;
            command.Parameters.Add("@Role", MySqlDbType.VarChar).Value = userInfo.role;
            command.Parameters.Add("@Gender", MySqlDbType.VarChar).Value = userInfo.gender;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = userInfo.name;
            command.Parameters.Add("@Avatar", MySqlDbType.LongBlob).Value = userInfo.avatar.ToArray();
            command.Parameters.Add("@Birthday", MySqlDbType.Date).Value = userInfo.birthday;
            return command;
        }

        public static MySqlCommand updatePassword(string newPassword, string userId)
        {
            //UPDATE `user` SET `Password` = '70ba33708cbfb103f1a8e34afef333ba7dc021022b2d9aaa583aabb8058d8d67' WHERE `user`.`Id` = 'a123';
            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `Password`=@Pass WHERE `Id` = @Id", DatabaseConnector.getConnection);
            command.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = SHA256Encryptor.encrypt(newPassword);
            command.Parameters.Add("@Id", MySqlDbType.VarChar).Value = userId;
            return command;
        }
        public static MySqlCommand updateUserInfoWithPassword(UserInfo userInfo)
        {
            //MySqlCommand command = new MySqlCommand("UPDATE `user` SET `Mail`='@Mail',`Password`='@Password',`PhoneNumber`='@PhoneNumber',`Address`='@Address',`Role`='@Role',`Gender`='@Gender',`Name`='@Name',`Avatar`='@Avatar',`Birthday`='@Birthday'" +
            //                                        "WHERE `Id`= @Id", DatabaseConnector.getConnection);
            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `Password`= @Password, `PhoneNumber`= @PhoneNumber, `Mail`= @Mail, `Role`= @Role, `Address`= @Address, `Gender`= @Gender,`Name`= @Name,`Avatar`= @Avatar,`Birthday`= @Birthday " +
                                                    "WHERE `Id`= @Id", DatabaseConnector.getConnection);
            command.Parameters.Add("@Id", MySqlDbType.VarChar).Value = userInfo.id;
            command.Parameters.Add("@Mail", MySqlDbType.VarChar).Value = userInfo.mail;
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = SHA256Encryptor.encrypt(userInfo.password);
            command.Parameters.Add("@PhoneNumber", MySqlDbType.VarChar).Value = userInfo.phoneNumber;
            command.Parameters.Add("@Address", MySqlDbType.VarChar).Value = userInfo.address;
            command.Parameters.Add("@Role", MySqlDbType.VarChar).Value = userInfo.role;
            command.Parameters.Add("@Gender", MySqlDbType.VarChar).Value = userInfo.gender;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = userInfo.name;
            command.Parameters.Add("@Avatar", MySqlDbType.LongBlob).Value = userInfo.avatar.ToArray();
            command.Parameters.Add("@Birthday", MySqlDbType.Date).Value = userInfo.birthday;
            return command;
        }


        public static MySqlCommand getAllUserIdByRole(string role)
        {
            MySqlCommand command = new MySqlCommand("SELECT `Id` FROM `user` WHERE `Role` = @Role", DatabaseConnector.getConnection);
            command.Parameters.Add("@Role", MySqlDbType.VarChar).Value = role;
            return command;
        }

        public static MySqlCommand getAllUserInfoExceptPassword()
        {
            MySqlCommand command = new MySqlCommand("SELECT `Avatar`, `Id`, `Name`, `Birthday`, `Gender`, `Mail`, `PhoneNumber`, `Address`, `Role` FROM `user`", DatabaseConnector.getConnection);
            return command;
        }

        public static MySqlCommand getUserInfoExceptPasswordByFilter(string id, string name)
        {
            MySqlCommand command = new MySqlCommand("SELECT `Avatar`, `Id`, `Name`, `Birthday`, `Gender`, `Mail`, `PhoneNumber`, `Address`, `Role` FROM `user` WHERE Id LIKE '%" + id + "%' AND Name LIKE '%" + name + "%' ORDER BY Id", DatabaseConnector.getConnection);
            return command;
        }

        #endregion

        #region Admin Command
        public static MySqlCommand addUser(UserInfo userInfo)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `user`(`Id`, `Mail`, `Password`, `PhoneNumber`, `Address`, `Role`, `Gender`, `Name`, `Avatar`, `Birthday`)" +
                                                    "VALUES           (@Id, @Mail, @Password, @PhoneNumber, @Address, @Role, @Gender, @Name, @Avatar, @Birthday)",
                                                    DatabaseConnector.getConnection);
            command.Parameters.Add("@Id", MySqlDbType.VarChar).Value = userInfo.id;
            command.Parameters.Add("@Mail", MySqlDbType.VarChar).Value = userInfo.mail;
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = SHA256Encryptor.encrypt(userInfo.password);
            command.Parameters.Add("@PhoneNumber", MySqlDbType.VarChar).Value = userInfo.phoneNumber;
            command.Parameters.Add("@Address", MySqlDbType.VarChar).Value = userInfo.address;
            command.Parameters.Add("@Role", MySqlDbType.VarChar).Value = userInfo.role;
            command.Parameters.Add("@Gender", MySqlDbType.VarChar).Value = userInfo.gender;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = userInfo.name;
            command.Parameters.Add("@Avatar", MySqlDbType.LongBlob).Value = userInfo.avatar.ToArray();
            command.Parameters.Add("@Birthday", MySqlDbType.Date).Value = userInfo.birthday;
            return command;
        }

        public static MySqlCommand removeUser(UserInfo userInfo)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `user` WHERE `Id` = @Id", DatabaseConnector.getConnection);
            command.Parameters.Add("@Id", MySqlDbType.VarChar).Value = userInfo.id;
            return command;
        }

        public static MySqlCommand removeUser(string userId)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `user` WHERE `Id` = @Id", DatabaseConnector.getConnection);
            command.Parameters.Add("@Id", MySqlDbType.VarChar).Value = userId;
            return command;
        }

        public static MySqlCommand getAllUser()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user`", DatabaseConnector.getConnection);
            return command;
        }
        #endregion


        public static MySqlCommand getUserInfo(string userId)
        {
            MySqlCommand command = new MySqlCommand("SELECT `Id`, `Mail`, `Password`, `PhoneNumber`, `Address`, `Role`, `Gender`, `Name`, `Avatar`, `Birthday`" +
                                                    "FROM `user` WHERE `Id` = @Id", DatabaseConnector.getConnection);
            command.Parameters.Add("@Id", MySqlDbType.VarChar).Value = userId;
            return command;
        }

        public static MySqlCommand getUserInfo(UserInfo userInfo)
        {
            MySqlCommand command = new MySqlCommand("SELECT `Id`, `Mail`, `Password`, `PhoneNumber`, `Address`, `Role`, `Gender`, `Name`, `Avatar`, `Birthday`" +
                                                    "FROM `user` WHERE `Id` = @Id", DatabaseConnector.getConnection);
            command.Parameters.Add("@Id", MySqlDbType.VarChar).Value = userInfo.id;
            return command;
        }

        #region Message Command
        public static MySqlCommand addMessage(MessageInfo messageInfo)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `message`(`Content`, `ReceiverId`, `SenderId`, `SendDate`)" +
                                                    "VALUES             ('@Content','@ReceiverId','@SenderId','@SendDate')",
                                                    DatabaseConnector.getConnection);
            command.Parameters.Add("@Content", MySqlDbType.VarChar).Value = messageInfo._content;
            command.Parameters.Add("@ReceiverId", MySqlDbType.VarChar).Value = messageInfo._receiverId;
            command.Parameters.Add("@SenderId", MySqlDbType.VarChar).Value = messageInfo._senderId;
            command.Parameters.Add("@SendDate", MySqlDbType.DateTime).Value = DateTime.Now;
            return command;
        }
        #endregion

        #region student commands
        public static MySqlCommand getAllStudents()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` ORDER BY StudentId", 
                                                    DatabaseConnector.getConnection);
            return command;
        }

        public static MySqlCommand getStudent(string studentId)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE `StudentId` = @StudentId", 
                                                    DatabaseConnector.getConnection);
            command.Parameters.Add("@StudentId", MySqlDbType.VarChar).Value = studentId;
            return command;
        }

        public static MySqlCommand getStudentsByFilter(string id, string name)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE StudentId LIKE '%" + id + "%' AND Name LIKE '%" + name + "%' ORDER BY StudentId", DatabaseConnector.getConnection);
            return command;
        }


        public static MySqlCommand addStudent(StudentInfo studentInfo)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`Avatar`, `StudentId`, `Name`, `Birthday`, `Gender`, `Disease`, `UserId`, `ClassId`)" +
                                                     "VALUES             (@Avatar, @StudentId, @Name, @Birthday, @Gender, @Disease, @UserId, @ClassId)",
                                                     DatabaseConnector.getConnection);
            command.Parameters.Add("@Avatar", MySqlDbType.LongBlob).Value = studentInfo.avatar.ToArray();
            command.Parameters.Add("@StudentId", MySqlDbType.VarChar).Value = studentInfo.id;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = studentInfo.name;
            command.Parameters.Add("@Birthday", MySqlDbType.Date).Value = studentInfo.birthday;
            command.Parameters.Add("@Gender", MySqlDbType.VarChar).Value = studentInfo.gender;
            command.Parameters.Add("@Disease", MySqlDbType.VarChar).Value = studentInfo.disease;
            command.Parameters.Add("@UserId", MySqlDbType.VarChar).Value = studentInfo.parentInfo.id;
            command.Parameters.Add("@ClassId", MySqlDbType.VarChar).Value = studentInfo.classInfo.classId;
            return command;
        }

        public static MySqlCommand removeStudent(string studentId)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `student` WHERE `StudentId` = @StudentId", DatabaseConnector.getConnection);
            command.Parameters.Add("@StudentId", MySqlDbType.VarChar).Value = studentId;
            return command;
        }

        public static MySqlCommand updateStudent(StudentInfo studentInfo)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET `Avatar`= @Avatar,`Name`= @Name,`Birthday`= @Birthday,`Gender`= @Gender, `Disease`= @Disease,`UserId`= @UserId,`ClassId`= @ClassId " +
                                                    "WHERE `StudentId` = @StudentId",
                                                    DatabaseConnector.getConnection);
            command.Parameters.Add("@Avatar", MySqlDbType.LongBlob).Value = studentInfo.avatar.ToArray();
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = studentInfo.name;
            command.Parameters.Add("@Birthday", MySqlDbType.Date).Value = studentInfo.birthday;
            command.Parameters.Add("@Gender", MySqlDbType.VarChar).Value = studentInfo.gender;
            command.Parameters.Add("@Disease", MySqlDbType.VarChar).Value = studentInfo.disease;
            command.Parameters.Add("@UserId", MySqlDbType.VarChar).Value = studentInfo.parentInfo.id;
            command.Parameters.Add("@ClassId", MySqlDbType.VarChar).Value = studentInfo.classInfo.classId;
            command.Parameters.Add("@StudentId", MySqlDbType.VarChar).Value = studentInfo.id;
            return command;
        }
        #endregion

        #region class
        public static MySqlCommand getClassInfo(string classId)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `class` WHERE `ClassId` = @ClassId", DatabaseConnector.getConnection);
            command.Parameters.Add("@ClassId", MySqlDbType.VarChar).Value = classId;
            return command;
        }

        public static MySqlCommand getAllClassId()
        {
            MySqlCommand command = new MySqlCommand("SELECT `ClassId` FROM `class`", DatabaseConnector.getConnection);
            return command;
        }

        public static MySqlCommand getAllClassInfos()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `class` ORDER BY ClassId", DatabaseConnector.getConnection);
            return command;
        }

        public static MySqlCommand removeClassInfo(string classId)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `class` WHERE `ClassId` = @ClassId", DatabaseConnector.getConnection);
            command.Parameters.Add("@ClassId", MySqlDbType.VarChar).Value = classId;
            return command;
        }

        public static MySqlCommand addClassInfo(ClassInfo classInfo)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `class`(`ClassId`, `Name`, `Capacity`, `Year`)" +
                                                    "VALUES             (@ClassId, @Name, @Capacity, @Year)", DatabaseConnector.getConnection);
            command.Parameters.Add("@ClassId", MySqlDbType.VarChar).Value = classInfo.classId;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = classInfo.name;
            command.Parameters.Add("@Capacity", MySqlDbType.Int32).Value = classInfo.capacity;
            command.Parameters.Add("@Year", MySqlDbType.Int32).Value = classInfo.year;
            return command;
        }

        public static MySqlCommand updateClassInfo(ClassInfo classInfo)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `class` SET `Year`= @Year,`Name`= @Name,`Capacity`= @Capacity WHERE `ClassId` = @ClassId",
                                                    DatabaseConnector.getConnection);
            command.Parameters.Add("@ClassId", MySqlDbType.VarChar).Value = classInfo.classId;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = classInfo.name;
            command.Parameters.Add("@Capacity", MySqlDbType.Int32).Value = classInfo.capacity;
            command.Parameters.Add("@Year", MySqlDbType.Int32).Value = classInfo.year;
            return command;
        }

        public static MySqlCommand getClassesByFilter(string id, string name)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `class` WHERE ClassId LIKE '%" + id + "%' AND Name LIKE '%" + name + "%' ORDER BY ClassId", DatabaseConnector.getConnection);
            return command;
        }
        #endregion

        #region phancong

        public static MySqlCommand getPhanCongTable(string phanCongTableId)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `phancongtable` WHERE `PhanCongTableId` = @PhanCongTableId",
                                                    DatabaseConnector.getConnection);
            command.Parameters.Add("@PhanCongTableId", MySqlDbType.VarChar).Value = phanCongTableId;
            return command;
        }
        public static MySqlCommand getAllPhanCongTables()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `phancongtable`", DatabaseConnector.getConnection);
            return command;
        }

        public static MySqlCommand getPhanCongTablesByFilter(string classId, string teacherId, string phanCongTableId)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `phancongtable` WHERE ClassID LIKE '%" + classId + "%' AND UserId LIKE '%" + teacherId + "%' AND PhanCongTableId LIKE '%" + phanCongTableId + "%' ORDER BY ClassId",
                                                    DatabaseConnector.getConnection);
            return command;
        }

        public static MySqlCommand addPhanCongTable(PhanCongInfo phanCongInfo)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `phancongtable`(`Year`, `ClassID`, `UserID`, `PhanCongTableId`)" +
                                                    "VALUES                     (@Year,@ClassID,@UserID,@PhanCongTableId)",
                                                    DatabaseConnector.getConnection);
            command.Parameters.Add("@Year", MySqlDbType.Int32).Value = phanCongInfo.year;
            command.Parameters.Add("@ClassID", MySqlDbType.VarChar).Value = phanCongInfo.classId;
            command.Parameters.Add("@UserID", MySqlDbType.VarChar).Value = phanCongInfo.teacherId;
            command.Parameters.Add("@PhanCongTabelId", MySqlDbType.VarChar).Value = phanCongInfo.phanCongTableId;
            return command;
        }

        public static MySqlCommand updatePhanCongTable(PhanCongInfo phanCongInfo)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `phancongtable` SET `Year`=@Year,`ClassID`=@ClassID,`UserID`=@UserID" +
                                                    "WHERE PhanCongTableId = @PhanCongTableId",
                                                    DatabaseConnector.getConnection);
            command.Parameters.Add("@Year", MySqlDbType.Int32).Value = phanCongInfo.year;
            command.Parameters.Add("@ClassID", MySqlDbType.VarChar).Value = phanCongInfo.classId;
            command.Parameters.Add("@UserID", MySqlDbType.VarChar).Value = phanCongInfo.teacherId;
            command.Parameters.Add("@PhanCongTabelId", MySqlDbType.VarChar).Value = phanCongInfo.phanCongTableId;
            return command;
        }

        public static MySqlCommand removePhanCongTable(string phanCongTableId)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `phancongtable` WHERE `PhanCongTableId` = @PhanCongTableId",
                                                    DatabaseConnector.getConnection);
            command.Parameters.Add("@PhanCongTableId", MySqlDbType.VarChar).Value = phanCongTableId;
            return command;
        }
        #endregion

    }
}
