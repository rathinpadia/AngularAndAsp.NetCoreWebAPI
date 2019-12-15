import { TestBed } from '@angular/core/testing';

import { TrainingDetailService } from './training-detail.service';

describe('TrainingDetailService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: TrainingDetailService = TestBed.get(TrainingDetailService);
    expect(service).toBeTruthy();
  });
});
