﻿using CapaEntidad;
using CapaDatos;

namespace CapaDomain
{
    public class UsuarioDomain
    {
        private readonly UsuarioRepository _UsuarioRepository;

        public UsuarioDomain(UsuarioRepository usuarioRepository)
        {
            _UsuarioRepository = usuarioRepository;
        }

        public IEnumerable<Usuario> ObtenerUsuarioTodos()
        {
            try
            {
                return _UsuarioRepository.ObtenerUsuarioTodos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int InsertarUsuario(Usuario oUsuario)
        {
            try
            {
                return _UsuarioRepository.InsertarUsuario(oUsuario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ActualizarUsuario(Usuario oUsuario)
        {
            try
            {
                return _UsuarioRepository.ActualizarUsuario(oUsuario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int EliminarUsuario(int nId_Usuario)
        {
            try
            {
                return _UsuarioRepository.EliminarUsuario(nId_Usuario);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
