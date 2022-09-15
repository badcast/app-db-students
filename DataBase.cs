using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace DataBaseStudents
{
    public class DataBase
    {
        public const decimal VERSION = 1.0000001m;
        public class DProfile
        {
            /// <summary>
            /// Имя
            /// </summary>
            public string Name;
            /// <summary>
            /// Фамилия
            /// </summary>
            public string LastName;
            /// <summary>
            /// Отчество
            /// </summary>
            public string FamilyName;
            /// <summary>
            /// Дата рождения
            /// </summary>
            public DateTime Date;
            /// <summary>
            /// Адрес проживания
            /// </summary>
            public string AddressOfHome;
            /// <summary>
            /// Телефон
            /// </summary>
            public string TelephoneNumber;
            /// <summary>
            /// Эл. почта
            /// </summary>
            public string Email;
            /// <summary>
            /// Специальность
            /// </summary>
            public string Speciality;
            /// <summary>
            /// После какой школы ?
            /// </summary>
            public string AfterSchool;
            /// <summary>
            /// Школа
            /// </summary>
            public string School;
            /// <summary>
            /// ИИН
            /// </summary>
            public string IIN;
            /// <summary>
            /// Медосмотр
            /// </summary>
            public bool MedicalExmination;
            /// <summary>
            /// Заявление
            /// </summary>
            public bool Statement;
            /// <summary>
            /// Удостоверение личности
            /// </summary>
            public bool CertificateOfIdentity;
            /// <summary>
            /// Фото 3*4
            /// </summary>
            public bool Photo3or4;
            /// <summary>
            /// Аттестат
            /// </summary>
            public bool Certificate;
            /// <summary>
            /// Национальность
            /// </summary>
            public string National;
            /// <summary>
            /// Определяет, является ли пустой
            /// </summary>
            public bool IsEmpty { get { return Compare(this, Empty); } }

            public override string ToString()
            {
                return ToData(this);
            }

            public DProfile(string Name, string LastName, string FamilyName, DateTime Date, string Speciality, string AfterSchool,
                string School, bool MedicalExmination, bool Statement, bool CertificateOfIdentity, bool Photo3or4, bool Certificate, string AddressOfHome, string TelephoneNumber, string email, string IIN, string national)
            {
                this.Name = Name;
                this.LastName = LastName;
                this.FamilyName = FamilyName;
                this.Date = Date;
                this.Speciality = Speciality;
                this.AfterSchool = AfterSchool;
                this.School = School;
                this.MedicalExmination = MedicalExmination;
                this.Statement = Statement;
                this.CertificateOfIdentity = CertificateOfIdentity;
                this.Photo3or4 = Photo3or4;
                this.Certificate = Certificate;
                this.AddressOfHome = AddressOfHome;
                this.TelephoneNumber = TelephoneNumber;
                this.Email = email;
                this.IIN = IIN;
                this.National = national;
            }

            public static DProfile Create(string Name, string LastName, string FamilyName)
            {
                return Create(Name, LastName, FamilyName, DateTime.Now, "", "", "", false, false, false, false, false, "", "", "", "", "");
            }

            public static DProfile Create(string Name, string LastName, string FamilyName, DateTime Date, string Speciality, string AfterSchool,
                string School, bool MedicalExmination, bool Statement, bool CertificateOfIdentity, bool Photo3or4, bool Certificate, string AddressOfHome, string TelephoneNumber, string Email, string IIN, string National)
            {
                return new DProfile(Name, LastName, FamilyName, Date, Speciality, AfterSchool,
                School, MedicalExmination, Statement, CertificateOfIdentity, Photo3or4, Certificate, AddressOfHome, TelephoneNumber, Email, IIN, National);
            }

            public static DProfile Create(string data)
            {
                string[] tmps = data.Split('|');
                int pos = 0;
                string getPos()
                {
                    string val = tmps[pos];
                    pos++;
                    return val;
                }
                DateTime getDate()
                {
                    string d = getPos();
                    DateTime rr = DateTime.Now;
                    if (DateTime.TryParse(d, out rr))
                        return rr;
                    return rr;
                }

                return Create(getPos(), getPos(), getPos(), getDate(), getPos(), getPos(), getPos(), bool.Parse(getPos()), bool.Parse(getPos()), bool.Parse(getPos()), bool.Parse(getPos()), bool.Parse(getPos()), getPos(), getPos(), getPos(), getPos(), getPos());

            }

            public static string ToData(DProfile encode)
            {
                string d = "";
                void write(object val)
                {
                    d += val.ToString() + "|";
                }

                write(encode.Name);
                write(encode.LastName);
                write(encode.FamilyName);
                write(encode.Date);
                write(encode.Speciality);
                write(encode.AfterSchool);
                write(encode.School);
                write(encode.MedicalExmination);
                write(encode.Statement);
                write(encode.CertificateOfIdentity);
                write(encode.Photo3or4);
                write(encode.Certificate);
                write(encode.AddressOfHome);
                write(encode.TelephoneNumber);
                write(encode.Email);
                write(encode.IIN);
                write(encode.National);
                return d;
            }

            public static DProfile Empty = new DProfile("", "", "", DateTime.Now, "", "", "", false, false, false, false, false, "", "", "", "", "");

            public static bool Compare(DProfile a, DProfile b)
            {
                return a.Name == b.Name &&
                       a.LastName == b.LastName &&
                       a.FamilyName == b.FamilyName &&
                       a.Date == b.Date &&
                       a.Speciality == b.Speciality &&
                       a.AfterSchool == b.AfterSchool &&
                       a.Statement == b.Statement &&
                       a.CertificateOfIdentity == b.CertificateOfIdentity &&
                       a.School == b.School &&
                       a.MedicalExmination == b.MedicalExmination &&
                       a.Photo3or4 == b.Photo3or4 &&
                       a.Certificate == b.Certificate &&
                       a.AddressOfHome == b.AddressOfHome &&
                       a.Email == b.Email &&
                       a.TelephoneNumber == b.TelephoneNumber &&
                       a.IIN == b.IIN &&
                       a.National == b.National;
            }
        }
        private const string HeadTag = "Student's";

        private const string Dir = "StudentData";
        private static string SaveDir
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + Dir;
            }
        }
        private static string DataBaseFile
        {
            get
            {
                return SaveDir + "\\DataBase.db";
            }
        }

        public static DataBase dataBase;

        public List<DProfile> profiles;

        public DataGridView DataGridView { get; }

        public bool IsSuppotedLoadVersion { get; private set; }

        public DProfile current
        {
            get
            {
                if (DataGridView.CurrentRow == null)
                    return null;

                DataGridViewCellCollection cls = DataGridView.CurrentRow.Cells;
                if (cls.Count <= 0)
                    return null;
                var vl = cls[0].Value.ToString();
                int index = int.Parse(vl) - 1;
                if (index < 0 || index > profiles.Count - 1)
                    return null;

                return profiles[index];
            }
        }

        public DataBase(DataGridView DataGridView)
        {
            dataBase = this;
            profiles = new List<DProfile>();
            this.DataGridView = DataGridView;

            Load();

            if(!IsSuppotedLoadVersion)
            {
                MessageBox.Show("Версия базы данных на этом компьютере устарела или был поврежден. Для восстановления был перемещен в Рабочий стол под именем (Резеврное копия БД)");
            }
            RefreshView();

        }
        private bool HasProfileOut(ref DProfile profile)
        {
            if (profile == default(DProfile))
                return false;
            DProfile prof = profile;
            bool result = profiles.Any((f) =>
            {
                bool res = DProfile.Compare(f, prof);
                if (res)
                    prof = f;
                return res;
            });

            profile = prof;

            return result;
        }
        private int GetIndexFrom(DProfile prof)
        {
            int index = 0;
            foreach (var prf in profiles)
            {
                if (prf == prof)
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        //public DProfile[] GetProfilesFromName(string Name, bool exactСoincidence = false)
        //{
        //    profiles.Where((f) =>
        //    {
        //        bool equal = 

        //        if(f.Name == )
        //    });
        //}
        private FileStream GetStreamFile()
        {
            Directory.CreateDirectory(SaveDir);
            return File.Open(DataBaseFile, FileMode.OpenOrCreate);
        }
        public void RefreshView()
        {
            DataGridView db = this.DataGridView;
            void writeCell(int columnIndex, int index, string value)
            {
                db.Rows[index].Cells[columnIndex].Value = string.IsNullOrEmpty(value) ? "(пусто)" : value;
            }
            int sz = profiles.Count - db.Rows.Count;
            if (sz != 0)
            {
                if (sz > 0)
                {
                    db.Rows.Add(sz);
                }
                else
                {
                    for (int i = 0; i < Math.Abs(sz); i++)
                    {
                        db.Rows.RemoveAt(db.Rows.Count - 1);
                    }
                }
            }
            for (int i = 0; i < profiles.Count; i++)
            {
                DProfile prof = profiles[i];
                writeCell(0, i, (i + 1).ToString());
                writeCell(1, i, string.Format("{0} {1} {2}", profiles[i].Name, profiles[i].LastName, profiles[i].FamilyName));
                writeCell(2, i, prof.Date.ToShortDateString());
                writeCell(3, i, prof.Speciality);

            }
        }
        public bool AddProfile(DProfile profile)
        {
            if (profile.IsEmpty)
                return false;

            if (HasProfile(profile))
                return false;


            profiles.Add(profile);

            RefreshView();

            return true;
        }

        public bool HasProfile(DProfile profile)
        {
            return HasProfileOut(ref profile);
        }

        public bool RemoveProfile(DProfile profile)
        {
            bool res = profiles.Remove(profile);

            RefreshView();
            return res;
        }

        public bool RemoveProfileAt(int index)
        {
            return !(index < 0 || index > profiles.Count) && RemoveProfile(profiles[index]);
        }

        public bool ChangeProfileTo(DProfile from, DProfile to)
        {

            if (HasProfile(from) && !HasProfile(to))
            {
                profiles[GetIndexFrom(from)] = to;

                RefreshView();

                return true;
            }

            return false;
        }

        public DProfile GetActiveProfile()
        {
            return current;
        }

        public void Save()
        {
            void WriteDProfile(BinaryWriter bw, DProfile prf)
            {
                bw.Write(prf.AfterSchool);
                bw.Write(prf.Certificate);
                bw.Write(prf.CertificateOfIdentity);
                bw.Write(prf.Date.ToShortDateString());
                bw.Write(prf.FamilyName);
                bw.Write(prf.LastName);
                bw.Write(prf.MedicalExmination);
                bw.Write(prf.Name);
                bw.Write(prf.Photo3or4);
                bw.Write(prf.School);
                bw.Write(prf.Speciality);
                bw.Write(prf.Statement);
                bw.Write(prf.AddressOfHome);
                bw.Write(prf.TelephoneNumber);
                bw.Write(prf.Email);
                bw.Write(prf.IIN);
                bw.Write(prf.National);
            }

            void WriteUser(BinaryWriter bw, string userName, string key)
            {
                //User
                string b = Convert.ToBase64String(Encoding.UTF8.GetBytes(userName));
                bw.Write(b);
                //User key
                b = Convert.ToBase64String(Encoding.UTF8.GetBytes(key));
                bw.Write(b);
            }
            try
            {
                using (BinaryWriter bw = new BinaryWriter(GetStreamFile()))
                {
                    bw.Write(HeadTag.ToCharArray());
                    bw.Write(VERSION);
                    var pf = KeyProfiles.keyProfiles;
                    var list = pf.GetList();
                    int count = list.Count;
                    bw.Write(count);
                    for (int i = 0; i < count; i++)
                    {
                        var p = list[i];
                        WriteUser(bw, p.Key, p.Value);
                    }

                    count = profiles.Count;
                    bw.Write(count);
                    for (int p = 0; p < count; p++)
                    {
                        WriteDProfile(bw, profiles[p]);
                    }

                    Random r = new Random();
                    int random = r.Next(1024, 100240);
                    byte[] bytes = new byte[random];

                    var c = System.Security.Cryptography.RandomNumberGenerator.Create();
                    for (int i = 0; i < random; i++)
                    {
                        bw.Write((char)r.Next(0, ushort.MaxValue - 1));
                        bw.Write('\n');
                        c.GetBytes(bytes);
                        bw.Write(bytes);
                    }
                }
            }
            catch
            {

            }
        }

        public void Load()
        {
            DProfile ReadDProfile(BinaryReader br)
            {
                string AfterSchool = br.ReadString();
                bool cert = br.ReadBoolean();
                bool cerfOfId = br.ReadBoolean();
                string date = br.ReadString();
                string fam = br.ReadString();
                string lastName = br.ReadString();
                bool medic = br.ReadBoolean();
                string name = br.ReadString();
                bool photo = br.ReadBoolean();
                string scool = br.ReadString();
                string specia = br.ReadString();
                bool statement = br.ReadBoolean();
                string addr = br.ReadString();
                string tel = br.ReadString();
                string email = br.ReadString();
                string iin = br.ReadString();
                string nat = br.ReadString();
                DateTime d = DateTime.Now;
                DateTime.TryParse(date, out d);
                return DProfile.Create(name, lastName, fam, d, specia, AfterSchool, scool, medic, statement, cerfOfId, photo, cert, addr, tel, email, iin, nat);

            }

            KeyValuePair<string, string> ReadUser(BinaryReader br)
            {
                //User
                string user = Encoding.UTF8.GetString(Convert.FromBase64String(br.ReadString()));
                //Key
                string pass = Encoding.UTF8.GetString(Convert.FromBase64String(br.ReadString()));
                return new KeyValuePair<string, string>(user, pass);
            }

            try
            {
                FileStream fs = GetStreamFile();
                using (BinaryReader br = new BinaryReader(fs))
                {
                    if (br.BaseStream.Length == 0)
                    {
                        return;
                    }
                    br.ReadChars(HeadTag.Length);

                    decimal fver = -1;
                    try
                    {
                        fver = br.ReadDecimal();
                    }
                    catch
                    {

                    }

                    IsSuppotedLoadVersion = fver == VERSION;

                    if (!IsSuppotedLoadVersion)
                    {

                        fs.Close();
                        string desktopdir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        int i = 1;
                        string backupFile = "";
                        do
                        {
                            backupFile = desktopdir + "\\" + "Резервное копия БД.backup"+i;
                            i++;
                        } while (File.Exists(backupFile));
                        File.Move(DataBaseFile, backupFile);
                        return;
                    }

                    var pf = KeyProfiles.keyProfiles;
                    var list = pf.GetList();
                    int count = br.ReadInt32();
                    for (int i = 0; i < count; i++)
                    {
                        list.Add(ReadUser(br));
                    }

                    count = br.ReadInt32();
                    for (int p = 0; p < count; p++)
                    {
                        profiles.Add(ReadDProfile(br));
                    }
                }
            }
            catch
            {

            }
        }

    }
    public class KeyProfiles
    {
        public static KeyProfiles keyProfiles;

        private List<KeyValuePair<string, string>> __list;
        private string[] _userNameCaching;
        private bool _isChanged;

        public KeyProfiles()
        {
            keyProfiles = this;
            __list = new List<KeyValuePair<string, string>>();
            _isChanged = true;
        }

        private void _AddUser(string user, string key)
        {
            __list.Add(new KeyValuePair<string, string>(user, key));
            _isChanged = true;
        }

        private bool _DeleteUser(string user)
        {
            for (int i = 0; i < __list.Count; i++)
            {
                var obj = __list[i];
                if (obj.Key == user)
                {
                    __list.RemoveAt(i);
                    _isChanged = true;
                    return true;
                }
            }
            return false;
        }

        public bool ExistKey(string key)
        {
            return __list.AsParallel().Any((f) => key == f.Value);
        }

        public bool ExistUser(string user)
        {
            return __list.AsParallel().Any((f) => user == f.Key);
        }

        public bool HasUserKey(string user, string key)
        {
            return __list.AsParallel().Any((f) => user == f.Key && key == f.Value);
        }

        public bool AddKey(string userName, string key)
        {
            if (ExistUser(userName))
                return false;

            _AddUser(userName, key);

            return true;
        }

        public bool DeleteUser(string user)
        {
            return _DeleteUser(user);
        }

        public string[] GetUsers()
        {
            int count = __list.Count;
            if (_isChanged)
            {
                _userNameCaching = new string[count];
                for (int i = 0; i < count; i++)
                {
                    _userNameCaching[i] = __list[i].Key;
                }
            }

            return _userNameCaching;
        }

        public List<KeyValuePair<string, string>> GetList()
        {
            return __list;
        }

    }
}
