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

        public async static Task<bool> Guardar(Estudiante estudiante) {
            if (!await Existe(estudiante.EstudianteId))
                return await Insertar(estudiante);
            else
                return await Modificar(estudiante);
        }

        private async static Task<bool> Insertar(Estudiante estudiante) {
            bool paso = false;
            Contexto contexto = new Contexto();

            try {
                contexto.Estudiantes.Add(estudiante);
                paso = await contexto.SaveChangesAsync() > 0;
            } catch (Exception) {
                throw;
            } finally {
                await contexto.DisposeAsync();
            }

            return paso;
        }

        public async static Task<bool> Modificar(Estudiante estudiante) {
            bool paso = false;
            Contexto contexto = new Contexto();

            try {
                contexto.Entry(estudiante).State = EntityState.Modified;

                paso = await contexto.SaveChangesAsync() > 0;

            } catch (Exception) {

                throw;
            } finally {
                await contexto.DisposeAsync();
            }
            return paso;
        }

        public async static Task<bool> Eliminar(int id) {
            bool paso = false;
            Contexto contexto = new Contexto();
            try {
                var estudiante = contexto.Estudiantes.Find(id);

                if (estudiante != null) {
                    contexto.Estudiantes.Remove(estudiante);
                    paso = await contexto.SaveChangesAsync() > 0;
                }
            } catch (Exception) {
                throw;
            } finally {
                await contexto.DisposeAsync();
            }

            return paso;
        }

        public async static Task<Estudiante> Buscar(int id) {
            Contexto contexto = new Contexto();
            Estudiante estudiante;

            try {
                estudiante = await contexto.Estudiantes
                    .Where(e => e.EstudianteId == id)
                    .FirstOrDefaultAsync();
            } catch (Exception) {
                throw;
            } finally {
                await contexto.DisposeAsync();
            }

            return estudiante;
        }


        public async static Task<bool> Existe(int id) {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try {
                encontrado = await contexto.Estudiantes.AnyAsync(e => e.EstudianteId == id);
            } catch (Exception) {
                throw;
            } finally {
                await contexto.DisposeAsync();
            }

            return encontrado;
        }

        public async static Task<List<Estudiante>> GetEstudiantes() {
            Contexto contexto = new Contexto();

            List<Estudiante> estudiantes = new List<Estudiante>();
            await Task.Delay(01); //Para dar tiempo a renderizar el mensaje de carga

            try {
                estudiantes = await contexto.Estudiantes.ToListAsync();

            } catch (Exception) {

                throw;
            } finally {
                await contexto.DisposeAsync();
            }

            return estudiantes;

        }


    }

}