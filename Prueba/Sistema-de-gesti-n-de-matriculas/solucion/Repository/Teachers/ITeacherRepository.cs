using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solucion.DTOs;

namespace solucion.Repository.Teachers
{
    public interface ITeacherRepository
    {
        Task<IEnumerable<TeacherGetDto>> ListTeacher();
        Task<TeacherPostDto> CreateTeacher(TeacherPostDto teacherPostDtoken);
        Task<TeacherGetDto> StudentById(int id);
        Task<TeacherPostDto> UpdateTeacher(int id, TeacherPostDto teacherPostDto);
        Task<IEnumerable<TeacherDate>> ListTeacherDate(int id);
    }
}