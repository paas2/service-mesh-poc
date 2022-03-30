import { check } from 'k6';
import http from 'k6/http';

export const options = {
    discardResponseBodies: true,
    scenarios: {
        contacts: {
            executor: 'per-vu-iterations',
            vus: 100,
            iterations: 200,
            maxDuration: '200s',
        },
    },
};

export default function () {
    http.get('http://localhost:3000/Test?isLong=false');
}