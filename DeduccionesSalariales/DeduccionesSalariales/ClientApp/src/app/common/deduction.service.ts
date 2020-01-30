import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

export class DeductionService {
    constructor(private httpClient: HttpClient) {
    }

    public get() {
        return this.httpClient.get(`home`);
    }
}
