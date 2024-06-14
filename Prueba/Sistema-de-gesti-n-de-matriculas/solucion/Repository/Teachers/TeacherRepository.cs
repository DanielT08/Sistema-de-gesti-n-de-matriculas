using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using solucion.Data;
using solucion.DTOs;
using solucion.Models;


namespace solucion.Repository.Teachers
{
    public class TeacherRepository: ITeacherRepository
    {
        public readonly BaseContext _context;
        public readonly IMapper _mapper;
        public TeacherRepository(BaseContext context, IMapper mapper ){
            _context = context;
            _mapper = mapper;
        }

        public async Task<TeacherPostDto> CreateTeacher(TeacherPostDto teacherPostDtoken)
        {
            var teacher = new Teacher{
                Names = teacherPostDtoken.Names,
                Specialty = teacherPostDtoken.Specialty,
                Phone= teacherPostDtoken.Phone,
                Email= teacherPostDtoken.Email,
                YearsExperience= teacherPostDtoken.YearsExperience
            };

            _context.teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();

            return teacherPostDtoken;
        }
 
        public Task<IEnumerable<TeacherGetDto>> ListTeacher()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TeacherDate>> ListTeacherDate(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TeacherGetDto> StudentById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TeacherPostDto> UpdateTeacher(int id, TeacherPostDto teacherPostDto)
        {
            throw new NotImplementedException();
        }
    }
}