using FluentMigrator;

namespace SerenePSM.Migrations.DefaultDB;
[DefaultDB, MigrationKey(20160516_0727)]
public class DefaultDB_20160516_0727_UserPreferences : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("Test")
            .WithColumn("TestID").AsInt32().PrimaryKey().Identity()
            .WithColumn("Name").AsString(255).NotNullable()
            .WithColumn("Phone").AsString(50).Nullable()
            .WithColumn("Address").AsString(500).Nullable()
            .WithColumn("Email").AsString(255).Nullable()
            .WithColumn("CreatedDate").AsDateTime().WithDefault(SystemMethods.CurrentUTCDateTime);

        Create.Index("IX_Test_Name_Phone")
            .OnTable("Test")
            .OnColumn("Name").Ascending()
            .OnColumn("Phone").Ascending()
            .WithOptions().NonClustered();
    }
}