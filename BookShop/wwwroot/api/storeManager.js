import axios from 'axios';

const http = axios.create();

function saveEntity(entityName, data) {
    let headers = {
        'Content-Type': 'application/json; charset=UTF-8'
    };
    if (data.id === 0) {
        return http.post(`/${entityName}`, data, {
            headers
        });
    } else {
        return http.put(`/${entityName}`, data, {
            headers
        });
    }
};

export default {
    getListFromServer(url){
        return http.get(url);
    },
    information() {
        return http.get(`/publisher`).then((response) => {
            return response.data;
        }).catch(() => {
            alert("Failed to display temporary file information");
        });
    }
};
