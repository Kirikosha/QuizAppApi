using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizAppApi.Migrations
{
    /// <inheritdoc />
    public partial class namingchangesecindtry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameIndex(
                name: "IX_Results_UserId",
                table: "results",
                newName: "IX_results_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Results_QuizId",
                table: "results",
                newName: "IX_results_QuizId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_QuizId",
                table: "questions",
                newName: "IX_questions_QuizId");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_QuestionId",
                table: "answers",
                newName: "IX_answers_QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_results",
                table: "results",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_quizes",
                table: "quizes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_questions",
                table: "questions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_answers",
                table: "answers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_answers_questions_QuestionId",
                table: "answers",
                column: "QuestionId",
                principalTable: "questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_questions_quizes_QuizId",
                table: "questions",
                column: "QuizId",
                principalTable: "quizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_results_quizes_QuizId",
                table: "results",
                column: "QuizId",
                principalTable: "quizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_results_users_UserId",
                table: "results",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_answers_questions_QuestionId",
                table: "answers");

            migrationBuilder.DropForeignKey(
                name: "FK_questions_quizes_QuizId",
                table: "questions");

            migrationBuilder.DropForeignKey(
                name: "FK_results_quizes_QuizId",
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

            migrationBuilder.RenameIndex(
                name: "IX_results_UserId",
                table: "Results",
                newName: "IX_Results_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_results_QuizId",
                table: "Results",
                newName: "IX_Results_QuizId");

            migrationBuilder.RenameIndex(
                name: "IX_questions_QuizId",
                table: "Questions",
                newName: "IX_Questions_QuizId");

            migrationBuilder.RenameIndex(
                name: "IX_answers_QuestionId",
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
    }
}
