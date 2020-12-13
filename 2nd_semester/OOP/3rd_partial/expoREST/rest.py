from flask import Flask, request
from flask_restful import Resource, Api


app = Flask(__name__)
api = Api(app)

Contactos = {}


class AgregarContacto(Resource):

    def get(self, IDContacto):
        return {IDContacto: Contactos[IDContacto]}

    def put(self, IDContacto):
        Contactos[IDContacto] = request.form['data']
        return {IDContacto: Contactos[IDContacto]}

    def delete(self, IDContacto):
        del Contactos[IDContacto]
        return "Contact deleted"


api.add_resource(AgregarContacto, '/<string:IDContacto>')


app.run()