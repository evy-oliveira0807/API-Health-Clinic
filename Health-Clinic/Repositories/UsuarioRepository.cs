using Health_Clinic.Contexts;
using Health_Clinic.Domains;
using Health_Clinic.Interfaces;
using Health_Clinic.Utils;

namespace Health_Clinic.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ClinicContext _clinicContext;
    
        private ClinicContext ctx;

        public UsuarioRepository()
        {
            ctx = new ClinicContext();
        }

        public Usuario BuscarPorEmailESenha(string email, string senha)
        {
            try
            {
                Usuario usuarioBuscado = _clinicContext.Usuario
                    .Select(u => new Usuario
                    {
                        IdUsuario = u.IdUsuario,
                        Nome = u.Nome,
                        Email = u.Email,
                        Senha = u.Senha,
                        IdTiposUsuario = u.IdTiposUsuario,
                        TiposUsuario = new TiposUsuario
                        {
                            Titulo = u.TiposUsuario!.Titulo
                        }

                    }).FirstOrDefault(u => u.Email == email)!;

                if (usuarioBuscado == null)
                {
                    throw new Exception("Email e/ou Senha incorretos.");
                }

                bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha!);

                if (confere)
                {
                    return usuarioBuscado;
                }

                throw new Exception("Email e/ou Senha incorretos.");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario BuscarPorId(string email, string senha)
        {
            try
            {
                Usuario usuarioBuscado = _clinicContext.Usuario
                    .Select(u => new Usuario
                    {
                        IdUsuario = u.IdUsuario,
                        Nome = u.Nome,
                        Email = u.Email,
                        TiposUsuario = new TiposUsuario
                        {
                            Titulo = u.TiposUsuario!.Titulo
                        }


                    }).FirstOrDefault(u => u.Email == email)!;
                ;

                if (usuarioBuscado == null)
                {
                    throw new Exception("O usuário não foi encontrado");
                }

                return usuarioBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario BuscarPorId(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                Usuario usuarioExistente = _clinicContext.Usuario.FirstOrDefault(u => u.Email == usuario.Email)!;

                if (usuarioExistente != null)
                {
                    throw new Exception("Email ja cadastrado!");
                }

                usuario.Senha = Criptografia.GerarHash(usuario.Senha!);

                _clinicContext.Add(usuario);

                _clinicContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

