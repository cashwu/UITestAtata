using Atata;

namespace testAtata
{
    using _ = UsersPage;

    [VerifyTitle]
    [VerifyH1]
    public class UsersPage : Page<_>
    {
        public ButtonDelegate<UserEditWindow, _> New { get; private set; }

        public Table<UserTableRow, _> Users { get; private set; }

        public class UserTableRow : TableRow<_>
        {
            public Text<_> FirstName { get; private set; }
        }
    }
}