using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using solucion.Data;
using solucion.DTOs;
using solucion.Models;

namespace solucion.Repository.Students
{
    public class StudentRepository: IStudentRepository
    {
        
        public readonly BaseContext _context;
        public readonly IMapper _mapper;
        public StudentRepository(BaseContext context, IMapper mapper ){
            _context = context;
            _mapper = mapper;
        }

        //----------------------------------- Listar estudiantes por fecha de nacimiento ------------------------------------
        public Task<IEnumerable<StudentBirthDate>> BirthdateStudent(DateTime date)
        {
            throw new NotImplementedException();
        }

        //--------------------------- Crear Student --------------------------------------------------------

        public async Task<StudentPostDto> CreateStudent(StudentPostDto createstudent)
        {
            var student = new Student
            {
                Names = createstudent.Names,
                BirthDate = createstudent.BirthDate,
                Address = createstudent.Address,
                Email = createstudent.Address
            };
             
            _context.students.AddAsync(student);
            await _context.SaveChangesAsync();

            return  createstudent;
        }


        //------------------ Listar Matriculas de un estudiante ---------------------------------------
        public Task<IEnumerable<StudentEnrr>> EnrrolmentStudent(int id)
        {
            throw new NotImplementedException();
        }


        //----------------------------------- Listar estudiantes ------------------------------------
        public async Task<IEnumerable<StudentGetDto>> ListStudent()
        {
            var student = await _context.students.ToListAsync();
            return _mapper.Map<IEnumerable<StudentGetDto>>(student);
        }

        //----------------------------------- Listar estudiantes por Id ------------------------------------
        public async Task<StudentGetDto> StudentById(int id)
        {
            var student = await _context.students.FindAsync(id);
            return _mapper.Map<StudentGetDto>(student);
        }

        //----------------------------------- Actualizar estudiantes ------------------------------------
        public async Task<StudentPostDto> UpdateStudent(int id, StudentPostDto UpdateStudent)
        {
            var student = await _context.students.FindAsync(id);
            if (student == null)return null;

            student.Names = UpdateStudent.Names;
            student.BirthDate = UpdateStudent.BirthDate;
            student.Address = UpdateStudent.Address;
            student.Email = UpdateStudent.Email;

            await _context.SaveChangesAsync();
            return  UpdateStudent;
        }
    }
}
