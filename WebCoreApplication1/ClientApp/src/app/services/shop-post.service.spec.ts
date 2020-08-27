import { TestBed } from '@angular/core/testing';

import { ShopPostService } from './shop-post.service';

describe('ShopPostService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ShopPostService = TestBed.get(ShopPostService);
    expect(service).toBeTruthy();
  });
});
