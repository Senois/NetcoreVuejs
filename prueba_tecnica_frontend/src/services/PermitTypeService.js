import http from "../repository/http-common";

class PermitTypeService {
  getAll() {
    return http.get("/getall");
  }
}

export default new PermitTypeService();