using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizAppApi.Migrations
{
    /// <inheritdoc />
    public partial class namingconventionrevert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "results",
                newName: "Results");

            migrationBuilder.RenameTable(
                name: "quizes",
                newName: "Quizes");

            migrationBuilder.RenameTable(
                name: "questions",
                newName: "Questions");

            migrationBuilder.RenameTable(
                name: "answers",
                newName: "Answers");

            migrationBuilder.RenameColumn(
                name: "username",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "user_name",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "two_factor_enabled",
                table: "Users",
                newName: "TwoFactorEnabled");

            migrationBuilder.RenameColumn(
                name: "security_stamp",
                table: "Users",
                newName: "SecurityStamp");

            migrationBuilder.RenameColumn(
                name: "phone_number_confirmed",
                table: "Users",
                newName: "PhoneNumberConfirmed");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "Users",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "password_hash",
                table: "Users",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "normalized_user_name",
                table: "Users",
                newName: "NormalizedUserName");

            migrationBuilder.RenameColumn(
                name: "normalized_email",
                table: "Users",
                newName: "NormalizedEmail");

            migrationBuilder.RenameColumn(
                name: "lockout_end",
                table: "Users",
                newName: "LockoutEnd");

            migrationBuilder.RenameColumn(
                name: "lockout_enabled",
                table: "Users",
                newName: "LockoutEnabled");

            migrationBuilder.RenameColumn(
                name: "email_confirmed",
                table: "Users",
                newName: "EmailConfirmed");

            migrationBuilder.RenameColumn(
                name: "concurrency_stamp",
                table: "Users",
                newName: "ConcurrencyStamp");

            migrationBuilder.RenameColumn(
                name: "access_failed_count",
                table: "Users",
                newName: "AccessFailedCount");

            migrationBuilder.RenameColumn(
                name: "correct",
                table: "Results",
                newName: "Correct");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Results",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Results",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "result_percentage",
                table: "Results",
                newName: "ResultPercentage");

            migrationBuilder.RenameColumn(
                name: "quiz_id",
                table: "Results",
                newName: "QuizId");

            migrationBuilder.RenameIndex(
                name: "ix_results_user_id",
                table: "Results",
                newName: "IX_Results_UserId");

            migrationBuilder.RenameIndex(
                name: "ix_results_quiz_id",
                table: "Results",
                newName: "IX_Results_QuizId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Quizes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Quizes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "creation_time",
                table: "Quizes",
                newName: "CreationTime");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "Questions",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Questions",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Questions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "quiz_id",
                table: "Questions",
                newName: "QuizId");

            migrationBuilder.RenameIndex(
                name: "ix_questions_quiz_id",
                table: "Questions",
                newName: "IX_Questions_QuizId");

            migrationBuilder.RenameColumn(
                name: "correct",
                table: "Answers",
                newName: "Correct");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Answers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "question_id",
                table: "Answers",
                newName: "QuestionId");

            migrationBuilder.RenameColumn(
                name: "answer_text",
                table: "Answers",
                newName: "AnswerText");

            migrationBuilder.RenameIndex(
                name: "ix_answers_question_id",
                table: "Answers",
                newName: "IX_Answers_QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Results",
                table: "Results",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quizes",
                table: "Quizes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answers",
                table: "Answers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Quizes_QuizId",
                table: "Questions",
                column: "QuizId",
                principalTable: "Quizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Quizes_QuizId",
                table: "Results",
                column: "QuizId",
                principalTable: "Quizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Users_UserId",
                table: "Results",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Quizes_QuizId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Quizes_QuizId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Users_UserId",
                table: "Results");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Results",
                table: "Results");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quizes",
                table: "Quizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answers",
                table: "Answers");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Results",
                newName: "results");

            migrationBuilder.RenameTable(
                name: "Quizes",
                newName: "quizes");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "questions");

            migrationBuilder.RenameTable(
                name: "Answers",
                newName: "answers");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "users",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "users",
                newName: "id");

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
                name: "Correct",
                table: "results",
                newName: "correct");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "results",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "results",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "ResultPercentage",
                table: "results",
                newName: "result_percentage");

            migrationBuilder.RenameColumn(
                name: "QuizId",
                table: "results",
                newName: "quiz_id");

            migrationBuilder.RenameIndex(
                name: "IX_Results_UserId",
                table: "results",
                newName: "ix_results_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_Results_QuizId",
                table: "results",
                newName: "ix_results_quiz_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "quizes",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "quizes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CreationTime",
                table: "quizes",
                newName: "creation_time");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "questions",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "questions",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "questions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "QuizId",
                table: "questions",
                newName: "quiz_id");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_QuizId",
                table: "questions",
                newName: "ix_questions_quiz_id");

            migrationBuilder.RenameColumn(
                name: "Correct",
                table: "answers",
                newName: "correct");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "answers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "answers",
                newName: "question_id");

            migrationBuilder.RenameColumn(
                name: "AnswerText",
                table: "answers",
                newName: "answer_text");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_QuestionId",
                table: "answers",
                newName: "ix_answers_question_id");

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
    }
}
