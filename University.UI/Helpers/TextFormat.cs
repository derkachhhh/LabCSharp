using University.Models.Enums;

namespace University.UI.Helpers;

public static class TextFormat
{
    public static string DepartmentTypeUa(DepartmentType type) => type switch
    {
        DepartmentType.ComputerScience => "Комп’ютерні науки",
        DepartmentType.Economics => "Економіка",
        DepartmentType.International_Relations => "Міжнародні відносини",
        _ => type.ToString()
    };

    public static string RankUa(AcademicRank rank) => rank switch
    {
        AcademicRank.Professor => "Професор",
        AcademicRank.AssociateProfessor => "Доцент",
        AcademicRank.SeniorLecturer => "Старший викладач",
        AcademicRank.Assistant => "Асистент",
        _ => rank.ToString()
    };
}