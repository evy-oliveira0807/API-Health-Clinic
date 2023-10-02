using Health_Clinic.Domains;
using Health_Clinic.Interfaces;
using Health_Clinic.Repositories;
using Health_Clinic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Health_Clinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
       
            private IUsuarioRepository _usuarioRepository;

          
            public LoginController()
            {
                _usuarioRepository = new UsuarioRepository();
            }

            [HttpPost]
            public IActionResult Post(LoginViewModel usuario)
            {
                try
                {
                    Usuario usuarioEncontrado = _usuarioRepository.BuscarPorEmailESenha(usuario.Email!, usuario.Senha!);

                    if (usuarioEncontrado == null)
                    {
                        return StatusCode(401, "Email ou senha inválidos");
                    }

                //lógica do token:

                var claims = new[]
                    {

                    
                    new Claim(JwtRegisteredClaimNames.Name, usuarioEncontrado.Nome!),
                    new Claim(JwtRegisteredClaimNames.Email, usuarioEncontrado.Email!),
                    new Claim("IdTiposUsuario", usuarioEncontrado.IdTiposUsuario.ToString()),
                    new Claim(ClaimTypes.Role, usuarioEncontrado.TiposUsuario!.Titulo!)
                };

                    var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("health-clinic-chave-autenticacao-webapi"));

                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken
                        (
                            issuer: "healthclinic_webapi",

                            audience: "healthclinic_webapi",

                            claims: claims,

                            expires: DateTime.Now.AddMinutes(10),

                            signingCredentials: creds
                        );

                    return Ok(new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(token)
                    });

                    
                }
                catch (Exception erro)
                {

                    return BadRequest(erro.Message);
                }
            }
        }
    }