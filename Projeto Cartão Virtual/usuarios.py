#encoding: utf-8
class Pessoa:
    def __init__(self, nome):
        self.nome = nome
        self.email = ""
        self.telefone = 0
        self.servico = ""
        self.__senha = ""
        
    def _email(self, email):
        self.email = email
        
    def _telefone(self, telefone):
        self.telefone = telefone
        
    def _senha(self, senha):
        self.__senha = senha
        
    def _servico(self, servico):
        self.servico = servico
        
    def _atributos(self):
        return {"Nome": self.nome, "Email": self.email, "Telefone": self.telefone, "Servico": self.servico}
    
    def __atributos(self):
        return {"Nome": self.nome, "Email": self.email, "Telefone": self.telefone, "Servico": self.servico, "Senha": self.__senha}