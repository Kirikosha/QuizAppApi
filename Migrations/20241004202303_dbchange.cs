using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizAppApi.Migrations
{
    /// <inheritdoc />
    public partial class dbchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_answers_questions_question_id",
                table: "answers");

            migrationBuilder.DropForeignKey(
                name: "FK_questions_quizes_quiz_id",
                table: "questions");

            migrationBuilder.DropForeignKey(
                name: "FK_results_quizes_quiz_id",
                table: "results");

            migrationBuilder.DropForeignKey(
                name: "FK_results_users_UserId",
                table: "results");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_results",
                table: "results");

            migrationBuilder.DropPrimaryKey(
                name: "PK_quizes",
                table: "quizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_questions",
                table: "questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_answers",
                table: "answers");

            migrationBuilder.DropColumn(
                name: "password",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "users",
                newName: "user_name");

            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "users",
                newName: "two_factor_enabled");

            migrationBuilder.RenameColumn(
                name: "SecurityStamp",
                table: "users",
                newName: "security_stamp");

            migrationBuilder.RenameColumn(
                name: "PhoneNumberConfirmed",
                table: "users",
                newName: "phone_number_confirmed");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "users",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "users",
                newName: "password_hash");

            migrationBuilder.RenameColumn(
                name: "NormalizedUserName",
                table: "users",
                newName: "normalized_user_name");

            migrationBuilder.RenameColumn(
                name: "NormalizedEmail",
                table: "users",
                newName: "normalized_email");

            migrationBuilder.RenameColumn(
                name: "LockoutEnd",
                table: "users",
                newName: "lockout_end");

            migrationBuilder.RenameColumn(
                name: "LockoutEnabled",
                table: "users",
                newName: "lockout_enabled");

            migrationBuilder.RenameColumn(
                name: "EmailConfirmed",
                table: "users",
                newName: "email_confirmed");

            migrationBuilder.RenameColumn(
                name: "ConcurrencyStamp",
                table: "users",
                newName: "concurrency_stamp");

            migrationBuilder.RenameColumn(
                name: "AccessFailedCount",
                table: "users",
                newName: "access_failed_count");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "results",
                newName: "user_id");

            migrationBuilder.RenameIndex(
                name: "IX_results_UserId",
                table: "results",
                newName: "IX_results_user_id");

            migrationBuilder.AddColumn<int>(
                name: "role",
                table: "users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "pk_users",
                table: "users",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_results",
                table: "results",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_quizes",
                table: "quizes",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_questions",
                table: "questions",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_answers",
                table: "answers",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_answers_questions_question_id",
                table: "answers",
                column: "question_id",
                principalTable: "questions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_questions_quizes_quiz_id",
                table: "questions",
                column: "quiz_id",
                principalTable: "quizes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_results_quizes_quiz_id",
                table: "results",
                column: "quiz_id",
                principalTable: "quizes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_results_users_user_id",
                table: "results",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_answers_questions_question_id",
                table: "answers");

            migrationBuilder.DropForeignKey(
                name: "fk_questions_quizes_quiz_id",
                table: "questions");

            migrationBuilder.DropForeignKey(
                name: "fk_results_quizes_quiz_id",
                table: "results");

            migrationBuilder.DropForeignKey(
                name: "fk_results_users_user_id",
                table: "results");

            migrationBuilder.DropPrimaryKey(
                name: "pk_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "pk_results",
                table: "results");

            migrationBuilder.DropPrimaryKey(
                name: "pk_quizes",
                table: "quizes");

            migrationBuilder.DropPrimaryKey(
                name: "pk_questions",
                table: "questions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_answers",
                table: "answers");

            migrationBuilder.DropColumn(
                name: "role",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "user_name",
                table: "users",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "two_factor_enabled",
                table: "users",
                newName: "TwoFactorEnabled");

            migrationBuilder.RenameColumn(
                name: "security_stamp",
                table: "users",
                newName: "SecurityStamp");

            migrationBuilder.RenameColumn(
                name: "phone_number_confirmed",
                table: "users",
                newName: "PhoneNumberConfirmed");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "users",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "password_hash",
                table: "users",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "normalized_user_name",
                table: "users",
                newName: "NormalizedUserName");

            migrationBuilder.RenameColumn(
                name: "normalized_email",
                table: "users",
                newName: "NormalizedEmail");

            migrationBuilder.RenameColumn(
                name: "lockout_end",
                table: "users",
                newName: "LockoutEnd");

            migrationBuilder.RenameColumn(
                name: "lockout_enabled",
                table: "users",
                newName: "LockoutEnabled");

            migrationBuilder.RenameColumn(
                name: "email_confirmed",
                table: "users",
                newName: "EmailConfirmed");

            migrationBuilder.RenameColumn(
                name: "concurrency_stamp",
                table: "users",
                newName: "ConcurrencyStamp");

            migrationBuilder.RenameColumn(
                name: "access_failed_count",
                table: "users",
                newName: "AccessFailedCount");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "results",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_results_user_id",
                table: "results",
                newName: "IX_results_UserId");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_results",
                table: "results",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_quizes",
                table: "quizes",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_questions",
                table: "questions",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_answers",
                table: "answers",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_answers_questions_question_id",
                table: "answers",
                column: "question_id",
                principalTable: "questions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_questions_quizes_quiz_id",
                table: "questions",
                column: "quiz_id",
                principalTable: "quizes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_results_quizes_quiz_id",
                table: "results",
                column: "quiz_id",
                principalTable: "quizes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_results_users_UserId",
                table: "results",
                column: "UserId",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
