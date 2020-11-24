import http from "../repository/http-common";

class PermitService {
  getAll() {
    return http.get("/getall");
  }

  create(model) {
    return http.post("/post/", model);
  }

  update(model) {
    return http.put("/put/", model);
  }

  delete(id) {
    return http.delete("/delete/", id);
  }
}

export default new PermitService();