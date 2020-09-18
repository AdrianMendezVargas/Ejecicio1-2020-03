using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio1_2020_03.DAL;
using Ejercicio1_2020_03.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio1_2020_03.BLL {

    public class EstudiantesBLL {

        public static bool Guardar(Estudiante estudiante) {
            if (!Existe(estudiante.EstudianteId))
                return Insertar(estudiante);
            else
                return Modificar(estudiante);
        }

        private static bool Insertar(Estudiante estudiante) {
            bool paso = false;
            Contexto contexto = new Contexto();

            try {
                contexto.Estudiantes.Add(estudiante);
                paso = contexto.SaveChanges() > 0;
            } catch (Exception) {
                throw;
            } finally {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Estudiante estudiante) {
            bool paso = false;
            Contexto contexto = new Contexto();

            try {
                contexto.Entry(estudiante).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
                Console.WriteLine("y modificado correctamente");
            } catch (Exception) {
                throw;
            } finally {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id) {
            bool paso = false;
            Contexto contexto = new Contexto();
            try {
                var estudiante = contexto.Estudiantes.Find(id);

                if (estudiante != null) {
                    contexto.Estudiantes.Remove(estudiante);
                    paso = contexto.SaveChanges() > 0;
                }
            } catch (Exception) {
                throw;
            } finally {
                contexto.Dispose();
            }

            return paso;
        }

        public static Estudiante Buscar(int id) {
            Contexto contexto = new Contexto();
            Estudiante estudiante;

            try {
                estudiante = contexto.Estudiantes
                    .Where(e => e.EstudianteId == id)
                    .FirstOrDefault();
            } catch (Exception) {
                throw;
            } finally {
                contexto.Dispose();
            }

            return estudiante;
        }


        public static bool Existe(int id) {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try {
                encontrado = contexto.Estudiantes.Any(e => e.EstudianteId == id);
            } catch (Exception) {
                throw;
            } finally {
                contexto.Dispose();
            }

            return encontrado;
        }

        public static List<Estudiante> GetEstudiantes() {
            Contexto contexto = new Contexto();

            List<Estudiante> estudiantes = new List<Estudiante>();

            try {
                estudiantes = contexto.Estudiantes.ToList<Estudiante>();

            } catch (Exception) {

                throw;
            } finally {
                contexto.Dispose();
            }

            return estudiantes;

        }


    }

}