"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var DeductionService = /** @class */ (function () {
    function DeductionService(httpClient) {
        this.httpClient = httpClient;
    }
    DeductionService.prototype.get = function () {
        return this.httpClient.get("home");
    };
    return DeductionService;
}());
exports.DeductionService = DeductionService;
//# sourceMappingURL=deduction.service.js.map